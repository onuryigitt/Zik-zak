using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public Transform topunkonumu;
    Vector3 eklenecekmiktar;
    void Start()
    {
        eklenecekmiktar = transform.position - topunkonumu.position;
    }

    void Update()
    {
        if(TopHareketi.düþtü_mü == false)
        {
            transform.position = topunkonumu.position + eklenecekmiktar;
        }
       
    }


}
