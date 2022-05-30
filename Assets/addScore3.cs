using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player_1").GetComponent<Score1>().AddScore1(1);
        
    }
}
