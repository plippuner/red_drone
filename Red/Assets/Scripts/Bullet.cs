using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    GameObject player;
    GameObject aggro;
    Rigidbody2D rb2d;
    Vector2 velocity;
    public float speed;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        Vector2 playerPos = player.transform.position;

        velocity.x = playerPos.x;
        velocity.y = playerPos.y;



        aggro = GameObject.Find("Blue");
        Vector2 aggroPos = aggro.transform.position;

        rb2d = GetComponent<Rigidbody2D>();

        //transform.position = new Vector3(aggroPos.x, aggroPos.y, 0);
    }

    // Update is called once per frame
    void Update () {
        Vector2 playerPos = player.transform.position;
        transform.Translate(playerPos * speed * Time.deltaTime);
    }
}
