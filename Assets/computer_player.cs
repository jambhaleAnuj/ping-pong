using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer_player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    public Rigidbody2D ball;
    public Vector3 startPosition;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {

        // if ball is coming towards the computer paddle
        if(this.ball.velocity.x > 0)
        {
            if(this.ball.position.y > this.transform.position.y)
            {
                body.AddForce(Vector2.up * this.speed);
            }
            else if(this.ball.position.y< this.transform.position.y){
                body.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if(this.transform.position.y > 0.0f)
            {
                body.AddForce(Vector2.down * this.speed);
            }
            else if(this.transform.position.y < 0.0f)
            {
                body.AddForce(Vector2.up * this.speed);
            }
        }
        

    }
    public void Reset()
    {
        body.velocity = Vector2.zero;
        transform.position = startPosition;

    }
}
