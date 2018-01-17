﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

    GameObject player;
    private Vector3 offset;

    void Start()
    {
        if (player != null) { 
        player = GameObject.Find("Player");
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = player.transform.position + offset;
        }
    }   }
