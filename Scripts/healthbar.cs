using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// script to replace healthbar when updating player's health

public class healthbar : MonoBehaviour
{
    public Sprite oneb, twob, threeb, fourb,fiveb, full;
    public  health playerhealth;
    Image bar;

    private void Awake()
    {
        bar = GetComponent<Image>();
    }

    public void SetBar(int status)
    {
        switch (status)
        {
            case 1:
                bar.sprite = oneb;
                break;
            case 2:
                bar.sprite = twob;
                break;
            case 3:
                bar.sprite = threeb;
                break;
            case 4:
                bar.sprite = fourb;
                break;
            case 5:
                bar.sprite = fiveb;
                break;
            case 6:
                bar.sprite = full;
                break;
        }
    }
    private void OnEnable()
    {

        Debug.Log(playerhealth.currHealth);
        Action updatehealth = () => SetBar(playerhealth.currHealth);
        health.OnPlayerDamaged += updatehealth;
        health.OnPlayerHeal += updatehealth;

    }

    /*
    private void OnDisable()
    {
        health.OnPlayerDamaged -= SetBar(playerhealth.currHealth);
    }
    */
}
