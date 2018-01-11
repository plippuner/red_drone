using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        // get player position
        Vector2 position = playerTransform.position;
        transform.position = new Vector2(position.x, position.y);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
