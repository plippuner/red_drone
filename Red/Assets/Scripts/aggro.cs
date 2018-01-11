using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aggro : MonoBehaviour {
    public Vector2 velocity;

    public GameObject go;
    public GameObject bulletEmitter;
    public float bulletForce;
    public float bulletDeathTime;

    public Rigidbody2D rb2d;
    public GameObject player;
    //private float spd = 4;
    private int distance = 7;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");

        // X = Left to Right
       // velocity.x = 0;
        // Y = Down to UP
        // velocity.y = 0;

    }
	
	// Update is called once per frame
	void Update () {
        float npcPosition = rb2d.position.x;
        float playerPosX = player.transform.position.x;
        float d = playerPosX-npcPosition;


        Debug.Log(Time.deltaTime);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        //rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);

        // Flucht
        if (d <= distance && d >= -distance) {
            if (3 - Time.deltaTime >= 0)
            {
                shoot();
            }
        }
        else
        {
            //gun.isFiring = false; // moving?
        }
    }

    void shoot()
    {
        GameObject tempBullet;
        tempBullet = Instantiate(go, transform.position, transform.rotation);

        Rigidbody2D tempRig;
        tempRig = tempBullet.GetComponent<Rigidbody2D>();
        Vector2 move = tempRig.transform.position;

        tempRig.AddForce(player.transform.position * bulletForce);
        //move.MoveTowards(transform.position, player.transform.position, 1000);

        Destroy(tempBullet, bulletDeathTime);
    }
}
