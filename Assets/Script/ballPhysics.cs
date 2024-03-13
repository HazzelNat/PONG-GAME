using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPhysics : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("goBall", 3);
    }

    private void goBall ()
    {
        float random = Random.Range(0,2);
        if (random < 1){
            if (random < 0.5){
                rb2d.AddForce(new Vector2(20, 15));
            } else {
                rb2d.AddForce(new Vector2(20, -15));
            }
        } else {
            if (random < 1.5){
                rb2d.AddForce(new Vector2(-20, 15));
            } else {
                rb2d.AddForce(new Vector2(-20, -15));
            }
        }
        
    }
}
