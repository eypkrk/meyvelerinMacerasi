using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    AudioSource soundControl;
    void Start()
    {
        soundControl = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("SesDurum") == 1)
        {
            soundControl.mute = false;
        }
        else
            soundControl.mute = true;
    }
}
