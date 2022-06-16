using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour
{
    private string previous;
    [System.Serializable]
    public class spawnpoints
    {
        public string name;
        public GameObject spawn;
    }

    public spawnpoints[] arr;

    public GameObject Player;


    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        previous = PlayerPrefs.GetString("previous");
       
        foreach(spawnpoints sp in arr)
        {
            if (sp.name == previous)
            {
                Player.transform.position = sp.spawn.gameObject.transform.position;
            }
        }
    }



}
