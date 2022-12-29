using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesAcKapaOlay : MonoBehaviour
{
    public GameObject ses_acik, ses_kapali;

    void Start()
    {
      //  PlayerPrefs.SetInt("sesDurum", 1);        ilk seferinde ses kapali old. b�yle yap�ld� ve ilk seferinde sesinn a��lmas� sa�land�
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("sesDurum") == 1)
        {
            ses_acik.SetActive(true);
            ses_kapali.SetActive(false);
        }
        else
        {
            ses_acik.SetActive(false);
            ses_kapali.SetActive(true);
        }
    }
    public void ses_durum(string durum)
    {
        if (durum == "acik") // ses kapama
        {
            ses_acik.SetActive(false);
            ses_kapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
        else if (durum == "kapali") // ses a�ma
        {
            ses_acik.SetActive(true);
            ses_kapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 1);
        }
    }
}
