using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Difficulty_select : MonoBehaviour
{
    public void onEasy()
    {
        SceneManager.LoadScene(2);
    }

    public void onNormal()
    {
        SceneManager.LoadScene(3);
    }

    public void onHard()
    {
        SceneManager.LoadScene(4);
    }
}
