using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public float hýz;
    public ZeminSpawner zeminspawnerscripti;
    public static bool düþtü_mü;
    public float eklenecekhýz;
    void Start()
    {
        yön = Vector3.forward;
        düþtü_mü = false;

    }

    [System.Obsolete]
    void Update()
    {
        if(transform.position.y<= -2f)
        {
            düþtü_mü = true;
            // Application.LoadLevel(Application.loadedLevel);  bulunduðun sahneyi çalýþtýrýr
            Application.LoadLevel(3);

        }
        if(düþtü_mü == true)
        {
            return;
        }

        //if (Input.GetMouseButtonDown(0) || Input.GetTouch(0).tapCount == 1)
            if (Input.GetMouseButtonDown(0))
        {        //masue down dersen her click bir anlamýna gelir

            if (yön.x == 0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
            hýz = hýz + eklenecekhýz * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
         
            collision.gameObject.AddComponent<Rigidbody>();   // zemini düþmesi
            zeminspawnerscripti.zemin_oluþtur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }
    IEnumerator ZeminiSil (GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(4f);
        Destroy(silinecekZemin);
    }


}
