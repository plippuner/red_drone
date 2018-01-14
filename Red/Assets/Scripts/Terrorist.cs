using System.Collections;
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


        // Flucht
        if (d < 0 && d >= -distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
            velocity.x = -spd;
        }
        else if (d > 0 && d <= distance)
        {
            gun.GetComponent<Shooting>().FireEnemyBullet();
            velocity.x = spd;
        }
        else
        {
            velocity.x = 0;
        }
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.GetComponent<Scoring>().tValue++;
        }
    }
}
