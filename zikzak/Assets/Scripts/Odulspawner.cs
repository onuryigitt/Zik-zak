using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odulspawner : MonoBehaviour
{
    public GameObject son_zemin;


    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            zemin_olu�tur();

        }

    }


    public void zemin_olu�tur()
    {
        Vector3 y�n;
        if (Random.Range(0, 2) == 0)
        {
            y�n = Vector3.left;
        }
        else
        {
            y�n = Vector3.forward;
        }

        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + y�n, son_zemin.transform.rotation);

        int spawnPickup = Random.Range(0, 10);
        if (spawnPickup == 0)
        {
            son_zemin.transform.GetChild(1).gameObject.SetActive(true);
        }


    }
}