using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terrorist : MonoBehaviour
{
    public Vector2 velocity;

    private Rigidbody2D rb2d;
    private GameObject player;
    public float spd;
    public int health;
    private int distance = 7;

    public List<string> negText = new List<string>();
    public List<string> posText = new List<string>();

    private Text redText;
    private Text blueText;

    private int tValue;
    private int textInt;

    private float textRate = 3f;
    private float stop = 2f;

    private bool random = true;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");

        transform.Find("Canvas").GetComponent<Canvas>().enabled = false;
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
            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
            GameObject gun = transform.Find("EnemyGun").gameObject;

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

>>>>>>> parent of 3d0aa21... replay3
        // Flucht
        if (d < 0 && d >= -distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
<<<<<<< HEAD
=======
            velocity.x = -spd;
>>>>>>> parent of 3d0aa21... replay3
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (d > 0 && d <= distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
<<<<<<< HEAD
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
>>>>>>> 204d178af3d3d100009d4196cea60da40645679b

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
            velocity.x = spd;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            velocity.x = 0;
        }
>>>>>>> parent of 3d0aa21... replay3
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.GetComponent<Scoring>().tValue++;
        }
    }
}
