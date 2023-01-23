using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecompletion : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Togglescreen()
    {
        gameObject.SetActive(true);
    }

}
