using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesKontrol : MonoBehaviour
{
    AudioSource ses_kontrol;
    void Start()
    {
        ses_kontrol= GetComponent<AudioSource>();
    }

 
    void Update()
    {
        if (PlayerPrefs.GetInt("sesDurum") == 1)
        {
            ses_kontrol.mute = false;
        }
        else
            ses_kontrol.mute= true;
    }
}
