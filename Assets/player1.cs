using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    
    public Vector3 startPosition;
    private float movement;

    public bool isPlayer1;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {

            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        

        rigidbody.velocity = new Vector2(0, movement * speed);
    }

    public void Reset()
    {
        rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
        
    }
}
