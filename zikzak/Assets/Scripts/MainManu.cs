using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void mainMenu()
    {
        SceneManager.LoadScene("MainManu");     // oyunda yazanla ayýný olmak zorunda
    }


    public void quitGame()
    {
        Application.Quit();
    }
   
   
}
