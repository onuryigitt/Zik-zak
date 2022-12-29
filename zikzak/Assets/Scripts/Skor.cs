using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public static int skor;
    public Text skortext;
    public Text highScore;

    void Start()
    {
        skor = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        
    }


    void Update()
    {
        skortext.text = skor.ToString();
        if(skor > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", skor);
            highScore.text = skor.ToString();
        }
       
    }
}
