using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    private AudioSource bg_music;
    public void PlayGame()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("playerprefs all deleted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Levels Completed", 0);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}