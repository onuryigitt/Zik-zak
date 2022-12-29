using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoLoader : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("Coutdown");

    }

    [System.Obsolete]
    private IEnumerator Coutdown ()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(1);
    }
}
