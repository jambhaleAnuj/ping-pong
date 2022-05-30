using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player_1").GetComponent<Score>().AddScore1(1);
        
    }
}
