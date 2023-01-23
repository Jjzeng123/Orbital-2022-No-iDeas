using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class sound_manager
{
    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audiosource = soundGameObject.AddComponent<AudioSource>();
        audiosource.PlayOneShot(GameAssets.i.correctanswer);
    }
}

