using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 y�n;
    public float h�z;
    public ZeminSpawner zeminspawnerscripti;
    public static bool d��t�_m�;
    public float eklenecekh�z;
    void Start()
    {
        y�n = Vector3.forward;
        d��t�_m� = false;

    }

    [System.Obsolete]
    void Update()
    {
        if(transform.position.y<= -2f)
        {
            d��t�_m� = true;
            // Application.LoadLevel(Application.loadedLevel);  bulundu�un sahneyi �al��t�r�r
            Application.LoadLevel(3);

        }
        if(d��t�_m� == true)
        {
            return;
        }

        //if (Input.GetMouseButtonDown(0) || Input.GetTouch(0).tapCount == 1)
            if (Input.GetMouseButtonDown(0))
        {        //masue down dersen her click bir anlam�na gelir

            if (y�n.x == 0)
            {
                y�n = Vector3.left;
            }
            else
            {
                y�n = Vector3.forward;
            }
            h�z = h�z + eklenecekh�z * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
         
            collision.gameObject.AddComponent<Rigidbody>();   // zemini d��mesi
            zeminspawnerscripti.zemin_olu�tur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }
    IEnumerator ZeminiSil (GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(4f);
        Destroy(silinecekZemin);
    }


}
