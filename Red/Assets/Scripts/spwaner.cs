using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

        if () { }
player = (GameObject.FindGameObjectWithTag("Player"));

DontDestroyOnLoad(gameObject);

if (GameObject.FindGameObjectWithTag("Player") != null)
{
    Destroy(gameObject);

}
else {

    Instantiate(player, transform.position, transform.rotation);

}

    }
}
