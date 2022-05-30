using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    
    public Vector3 startPosition;
    private float movement;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         
            movement = Input.GetAxisRaw("Vertical");
        
        

        rigidbody.velocity = new Vector2(0, movement * speed);
    }

    public void Reset()
    {
        rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
        
    }
}
