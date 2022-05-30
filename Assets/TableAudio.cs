using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAudio : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ball") == true)
        {
            audioSource.Play();
        }
    }
}
