using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 move;
    public float slideTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            move.x -= 1;

        }
        if(Input.GetKey(KeyCode.D))
        {
            move.x += 1;

        }
        if(Input.GetKey(KeyCode.W))
        {
            move.z += 1;

        }
        if(Input.GetKey(KeyCode.S))
        {
            move.z -= 1;

        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            move.x += 3;
            slideTime += 10;
        }
        move.y = rb.velocity.y;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            move.y += 10;
        }
        rb.velocity = move;
        move.z *= 0.9f;
        if(slideTime == 0)
        {
            move.x *= 0.9f;
            move.z *= 0.9f;
        }
        else
        {
            slideTime -= 1;
        }
        
    }
}
