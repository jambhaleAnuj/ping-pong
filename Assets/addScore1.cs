using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore1 : MonoBehaviour
{
     
     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player_2").GetComponent<Score1>().AddScore2(1);      
        
        
    }
}
