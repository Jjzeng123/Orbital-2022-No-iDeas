using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options_button : MonoBehaviour
{
    public bool isCorrect = false;
    public GameObject questionmenu;
    public GameObject enemy;
    private GameObject player;
    public GameObject soundmanager;
    public AudioClip[] sounds;
    health Health;

    void start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Health = (health)player.GetComponent(typeof(health));
        
    }

    void Update()
    {
        //if (PlayerPrefs.GetInt(enemy.name) == 0)
        //{
        //    enemy.SetActive(false);
        //    //Destroy(enemy);
        //    Debug.Log("Destroyed upon spawn");
        //}
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            questionmenu.SetActive(false);
            //Destroy(enemy);
            enemy.SetActive(false);
            PlayerPrefs.SetInt(enemy.name, 0);
            Debug.Log("disabled");
            //Debug.Log("destroyed");
            soundmanager.GetComponent<AudioSource>().PlayOneShot(sounds[0]);
            //enemy.GetComponent<enemy_status_new>().Die();
            Debug.Log(PlayerPrefs.GetInt(enemy.name));

        }
        else
        {
            Debug.Log("Wrong Answer");
            soundmanager.GetComponent<AudioSource>().PlayOneShot(sounds[1]);
            Health.TakeDamage(1);
        }
    }
}
