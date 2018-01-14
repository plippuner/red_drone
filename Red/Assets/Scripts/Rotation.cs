using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public Transform Explosion;
   // public ParticleSystem ps;
    bool Falling = true;
    public GameObject exp;



    // Use this for initialization
    void Start () {
        //  ps = GetComponent<ParticleSystem>();

        


    }
	
	// Update is called once per frame
	void Update () {



        if (Falling)
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -80));
            

        }
        else {

            //Explosion.GetComponent<ParticleSystem>().enabled = true;
            //Explosion.GetComponent<SpriteRenderer>().sprite = null;


            Instantiate(exp, transform.position, transform.rotation);

        
            Destroy(gameObject);
            

        }
       

		
	}




    void OnCollisionEnter2D(Collision2D col) {

  
        if (col.gameObject.tag == "Ground" ||col.gameObject.tag == "Civilian" ||col.gameObject.tag == "Terrorist" || col.gameObject.tag == "Structure") {
             

            //Explosion.GetComponent<ParticleSystem>().enableEmission = true;
            Falling = false;
            



           //Destroy(col.gameObject);

        }

    }
}
