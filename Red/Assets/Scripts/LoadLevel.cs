using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {


 public void Recordloading()
    {
        SceneManager.LoadScene("Aufnahme");
    }

    public void Gameloading()
    {
        SceneManager.LoadScene("Game");
    }

    public void Scoreloading()
    {
        SceneManager.LoadScene("Score");
    }




    public void Quit()
    {
        Application.Quit();
    }
}
