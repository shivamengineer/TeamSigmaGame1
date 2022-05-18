using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class EnemyAi1 : MonoBehaviour
 {
 
     public Transform Player;
     public float MoveSpeed = 0.09f;
     public int MaxDist = 10;
     public int MinDist = 5;
     public Vector2 lookPos;
 
 
 
 
     void Start()
     {
 
     }
 
     void Update()
     {
        lookPos = Player.position;
        //lookPos.z = transform.position.z;
        //transform.LookAt(lookPos);
        transform.position = Vector3.MoveTowards(transform.position, Player.position, MoveSpeed);
        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {
 
            //transform.position += transform.right * MoveSpeed * Time.deltaTime;
 
 
 
            if (Vector2.Distance(transform.position, Player.position) <= MaxDist)
            {
                //call a function here
            }
 
        }
     }
 }
 