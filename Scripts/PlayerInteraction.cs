using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    //private int score = 0;
    //public Text scoreText;
    public health playerhealth;
    public CameraShake camerashake;

    private void Start()
    {
        playerhealth = GetComponent<health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Player dies if player collides with a trigger collider with the Death tag
        if (collision.tag == "Death")
        {
            //Restart the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //Player to proceed to next level if player collides with a trigger collider with the Finish tag
        if (collision.tag == "Finish")
        {
            //Load next level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       
        }
        ////If player collide with a trigger collider with the Coin tag, add 100 to score and destroy the coin
        //if (collision.tag == "Coin")
        //{
        //    score = score + 100;
        //    scoreText.text = score.ToString();
        //    Destroy(collision.gameObject);
        //}

        if (collision.tag == "Front IO")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Front IO");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if(collision.tag == "Motherboard")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Motherboard");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "CPU")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("CPU");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "Memory")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Memory");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "SSD")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("SSD");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "HDD")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("HDD");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "GPU")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("GPU");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "Rear IO")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Rear IO");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

        if (collision.tag == "blank testing")
        {
            PlayerPrefs.SetString("previous", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("blank level - testing");
            PlayerPrefs.SetInt("playerhealth", playerhealth.currHealth);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(camerashake.Shake(0.1f, 0.1f));
        }
    }


}
