using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public Vector2 movementA;

    public bool left = false;
    public bool right = false;
    public bool up = false;
    public bool down = false;
    public bool rolling = false;

    public int aaa;
    public int speed;

    // Start is called before the first frame update
    void Start(){
        speed = 18;
    
    }
    // Update is called once per frame
    void Update(){
        
        if(Input.GetKeyDown(KeyCode.A)){
            left = true;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            right = true;
        }
        if(Input.GetKeyDown(KeyCode.W)){
            up = true;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            down = true;
        }
        
        if(Input.GetKeyUp(KeyCode.A)){
            left = false;
        }
        if(Input.GetKeyUp(KeyCode.D)){
            right = false;
        }
        if(Input.GetKeyUp(KeyCode.W)){
            up = false;
        }
        if(Input.GetKeyUp(KeyCode.S)){
            down = false;
        }

        if((right&&left)||((right==false)&&(left==false))){
            movementA.x = 0;
        } else {
            if(left){
                movementA.x = (-speed);
            }
            if(right){
                movementA.x = (speed);
            }
        }
        if(up&&down||((up==false)&&(down==false))){
            movementA.y = 0;
        } else {
            if(up){
                movementA.y = (speed);
            }
            if(down){
                movementA.y = (-speed);
            }
        }
        
        //transform.localScale.x *= 2;

    }
    void FixedUpdate(){
        //50 times per second
        if(Input.GetKeyDown(KeyCode.F)){
            if(rolling == false){ 
                aaa = 0;
                while(aaa < 1000){
                    rolling = true;
                    rb.velocity = (movementA * 10);
                    aaa++;
                }
                rolling = false;
            }
        } else {
            rb.velocity = movementA;
        }
    }
}
