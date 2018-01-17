using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour {


    private GameObject player;


     void Start()
    {
        player = (GameObject.FindGameObjectWithTag("Player"));
    }

   
	
	// Update is called once per frame
	void Update () {


if (GameObject.FindGameObjectWithTag("Player") == null)
{
            if (Input.GetKey(KeyCode.KeypadEnter)) { }
            Instantiate(player, transform.position, transform.rotation);
           

}


    }
}
