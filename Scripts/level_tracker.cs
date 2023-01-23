using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_tracker : MonoBehaviour {

    public gamecompletion completion_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int levels_completed = PlayerPrefs.GetInt("Levels Completed");
        Debug.Log(levels_completed);
        if(levels_completed == 7)
        {
            completion_screen.Togglescreen();
            gameObject.GetComponent<PlayerController>().enabled = false;
        }
    }
}
