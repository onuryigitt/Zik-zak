using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sescalma2 : MonoBehaviour
{
    public AudioSource Ses;
    public AudioClip SesClip;
    private void Awake()
    {
        foreach (Button obje in Resources.FindObjectsOfTypeAll<Button>())
        {
   
        }
    }

    public void Sescalma3()
    {
        Ses.PlayOneShot(SesClip, 1);
    }

}
