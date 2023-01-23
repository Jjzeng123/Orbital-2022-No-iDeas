using System.Collections;
using System.Linq;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemy_counter : MonoBehaviour
{
    public GameObject[] enemies;
    public TMP_Text count;
    public bool completed = false;
    // Start is called before the first frame update
    void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("special enemy");
        if (SceneManager.GetActiveScene().name == "Motherboard")
        {
            
                completed = true;
            

        }

    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("special enemy");
        count.text = enemies.Length.ToString();
        if (enemies.Length == 0 && !completed)
        {
            PlayerPrefs.SetInt("Levels Completed", PlayerPrefs.GetInt("Levels Completed") + 1);
            completed = true;
        }
        
    }
}
