using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public Transform Explosion;
    bool Falling = true;


	// Use this for initialization
	void Start () {

        Explosion.GetComponent<ParticleSystem>().enableEmission = false;


    }
	
	// Update is called once per frame
	void Update () {
        

        if (Falling)
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * 80));
        }
        else {

            Explosion.GetComponent<ParticleSystem>().enableEmission = true;
            Explosion.GetComponent<SpriteRenderer>().sprite = null;
           // Explosion.GetComponent<Rigidbody2D>().B = null;

            //Destroy(gameObject); 
        }
       

		
	}




    void OnCollisionEnter2D(Collision2D col) {

       
        Debug.Log("col");
       
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Destroy" ) {
            // Debug.Log("col");

            Explosion.GetComponent<ParticleSystem>().enableEmission = true;
            Falling = false;



            //Destroy(gameObject);

        }

    }
}
