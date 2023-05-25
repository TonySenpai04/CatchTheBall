using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public static LoadScene instance;
    private void Start()
    {
        instance = this;
    }
    public void loadgame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
       // Application.LoadLevel("Main");
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void loadmenu()
    {
        SceneManager.LoadScene(0);
       // Application.LoadLevel("Menu");
    }

}
