using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    public GameObject audioOn;
    public GameObject audioOff;

   public void singlePlayer()
    {
        SceneManager.LoadScene(5);
    }

    public void local_multiplayer()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Local Multiplayer Loaded");
    }

    

    public void onExit()
    {
        Application.Quit();
        Debug.Log("Exit button pressed");
    }


    
}
