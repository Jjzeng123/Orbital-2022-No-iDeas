using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int maxHealth = 6;
    public int currHealth;
    public gameover gameovermenu;
    public healthbar healthbars;
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerHeal;
    public GameObject soundmanagersimple;
    public AudioClip[] simplesounds;

    // Start is called before the first frame update
    void Awake()
    {
        currHealth = maxHealth;
        int playerhealth = PlayerPrefs.GetInt("playerhealth");
        if(playerhealth == 0)
        {
            PlayerPrefs.SetInt("playerhealth", maxHealth);
            currHealth = maxHealth;
        }
        else
        {
            currHealth = playerhealth;
        }
        healthbars.SetBar(currHealth);

    }

    public void TakeDamage(int amount)
    {
        currHealth -= amount;
        // animate flashing??
        Debug.Log(currHealth);
        if (currHealth <= 0) // need to work out this weird thing...
        if (currHealth <= 1) // need to work out this weird thing...
        if (currHealth < 1) // need to work out this weird thing...
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            
        }
        if (currHealth <= 1)
        {
            gameovermenu.ToggleMenu();
        }
        Debug.Log("damage taken");
        OnPlayerDamaged?.Invoke();
    }

    void Heal(int amount)
    {
        currHealth += amount;
        if (currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }
        Debug.Log("player healed");
        OnPlayerHeal?.Invoke();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("potion"))
        { 
            if(currHealth != maxHealth)
            {
                Destroy(collision.gameObject);
                soundmanagersimple.GetComponent<AudioSource>().PlayOneShot(simplesounds[1]);
                Debug.Log(currHealth);
            }
            Heal(1);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
            soundmanagersimple.GetComponent<AudioSource>().PlayOneShot(simplesounds[0]);
        }
    }
}
