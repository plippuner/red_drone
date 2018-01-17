﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrorist : MonoBehaviour
{
    public Vector2 velocity;

    private Rigidbody2D rb2d;
    private GameObject player;
    public float spd;
    public int health;
    private int distance = 7;

    private int tValue;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");

        // X = Left to Right
        velocity.x = 0;
        // Y = Down to UP
        velocity.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float npcPosition = rb2d.position.x;
        float playerPosX = player.transform.position.x;
        float d = playerPosX - npcPosition;

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
        GameObject gun = transform.Find("EnemyGun").gameObject;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of f9ab51a... Merge branch 'master' of https://github.com/plippuner/red_drone
            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
            GameObject gun = transform.Find("EnemyGun").gameObject;

<<<<<<< HEAD
=======
        redText = transform.Find("Canvas/redText").GetComponent<Text>();
        blueText = transform.Find("Canvas/blueText").GetComponent<Text>();

        textRate -= Time.deltaTime;
        if (textRate <= 0) {
            if (random)
            {
                textInt = Random.Range(0, posText.Count);
                transform.Find("Canvas").GetComponent<Canvas>().enabled = true;
                random = false;
            }
            redText.text = posText[textInt];
            blueText.text = negText[textInt];
            stop -= Time.deltaTime;
        }

        if (stop <= 0)
        {
            redText.text = "";
            blueText.text = "";
            textRate = 3f;
            stop = 2f;
            random = true;
            transform.Find("Canvas").GetComponent<Canvas>().enabled = false;
        }

        // Flucht
        if (d < 3 && d >= -distance)
        {
            velocity.x = -spd;
        }
        else if (d > 3 && d <= distance)
        {
            velocity.x = spd;
        } else
        {
            velocity.x = 0;
        }

=======
>>>>>>> parent of 4084da0... Dialogue

=======

>>>>>>> parent of 3d0aa21... replay3
        // Flucht
        if (d < 0 && d >= -distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
<<<<<<< HEAD
<<<<<<< HEAD
=======
            velocity.x = -spd;
>>>>>>> parent of 3d0aa21... replay3
=======
            velocity.x = -spd;
>>>>>>> parent of 4084da0... Dialogue
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (d > 0 && d <= distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
<<<<<<< HEAD
<<<<<<< HEAD
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
>>>>>>> 204d178af3d3d100009d4196cea60da40645679b
=======
>>>>>>> parent of f9ab51a... Merge branch 'master' of https://github.com/plippuner/red_drone

            // Flucht
            if (d < 0 && d >= -distance)
            {
                gun.GetComponent<Shooting>().FireEnemyBullet();
                velocity.x = -spd;
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (d > 0 && d <= distance)
            {
                gun.GetComponent<Shooting>().FireEnemyBullet();
                velocity.x = spd;
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                velocity.x = 0;
            }
        
=======
=======
>>>>>>> parent of 4084da0... Dialogue
            velocity.x = spd;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            velocity.x = 0;
        }
<<<<<<< HEAD
>>>>>>> parent of 3d0aa21... replay3
=======
>>>>>>> parent of 4084da0... Dialogue
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.GetComponent<Scoring>().tValue++;
        }
    }
}
