using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer>().flipX = transform.parent.GetComponent<SpriteRenderer>().flipX;
        GetComponent<SpriteRenderer>().flipY = transform.parent.GetComponent<SpriteRenderer>().flipY;

    }
}
