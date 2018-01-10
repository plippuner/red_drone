using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
    public Vector2 velocity;

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        // X = Left to Right
        velocity.x = 4;

        // Y = Down to UP
        velocity.y = -2;
    }
	
	// Update is called once per frame
	void Update () {

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
    }
}
