using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeath : MonoBehaviour
{

    public GameObject deathFrame;

    void Start()
    {
       // Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<EnemyAi1>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //Instantiate(deathFrame, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
