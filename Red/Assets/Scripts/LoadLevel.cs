using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {


 public void Recordloading()
    {
        SceneManager.LoadScene("Replay");
    }

    public void Gameloading()
    {
        SceneManager.LoadScene("red");
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
