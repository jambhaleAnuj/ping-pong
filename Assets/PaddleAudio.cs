using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAudio : MonoBehaviour
{

    public AudioSource audiosource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ball") == true)
        {
            
            audiosource.Play();
        }
    }
}
