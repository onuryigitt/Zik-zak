using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    internal object onClick;

    public void DigerSahne()
    {
        SceneManager.LoadScene ("MenuScane");
    }
}
