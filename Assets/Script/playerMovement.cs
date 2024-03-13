using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb2d.velocity;
        if(Input.GetKey(moveUp))
        {
            velocity.y = speed;
        } 
        else if (Input.GetKey(moveDown))
        {
            velocity.y = -speed;
        }
        else {
            velocity.y = 0;
        }
        rb2d.velocity = velocity;
    }
}
