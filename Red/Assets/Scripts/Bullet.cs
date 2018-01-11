using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    GameObject player;
    public Vector2 pos;
    private float bulletSpeed = 5;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Player");
        Vector2 playerPos = player.transform.position;
        //rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        //rb2d.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }

    void display(float posX, float posY)
    {
        posX = pos.x;
        posY = pos.y;

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<Rigidbody>();
        cube.transform.position = new Vector3(player.transform.x, player.transform.y, 0);
    }
}
