using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
     
     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player_2").GetComponent<Score>().AddScore2(1);      
        
        
    }
}
