using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal_trigger : MonoBehaviour
{
    public GameObject infomenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            infomenu.SetActive(true);
            Debug.Log("activated");
        }
    }


}
