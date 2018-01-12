using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class explosion : MonoBehaviour
{

    float Health = 1f;
    float liveTimer = 1f;
    float explosionTime = 15f;
    float Damage = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        explosionTime = explosionTime - liveTimer;

        if (explosionTime <= 0)
        {
            explosionTime = 0;
            Destroy(gameObject);

        }

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        

        if (col.gameObject.tag == "Civilian")
        {
            Health = Health - Damage;
            Debug.Log("kill");
        }
    }
}