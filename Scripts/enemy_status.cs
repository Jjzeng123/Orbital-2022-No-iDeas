using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_status : MonoBehaviour
{
    //public GameObject enemy;
    
    string playerPrefsString;
    void Awake()
    {
        playerPrefsString = SceneManager.GetActiveScene().name + "/" + transform.name;
        
    }
    public void Die()
    {
        PlayerPrefs.SetInt(playerPrefsString, 1);
        //enemy.SetActive(false);
    }

    
}
