using System.Collections;
using System.Collections.Generic;
using UnityEngine;




class Bombe : MonoBehaviour {

    float BombSizeX = 10;
    float BombSizeY = 10;
    float BombRoration = 0;
    Color BombColor;












}





public class Player : MonoBehaviour {



    
    float Playerspeed = 10;

    float Velocity = 0;
    Vector3 TrueVelocity;
    float Dump = 0.01f;
    bool Direction;
    public GameObject PlayerObjekt;



    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        drivter();
        Velocity = Playerspeed;
        transform.position = TrueVelocity;

        /*       if (!Input.anyKey)


               {
                   Dump = 0;
                   Velocity = 0;
               }*/





        if (Input.GetKey(KeyCode.D)) {


            TrueVelocity += new Vector3(Velocity * Time.deltaTime, 0.0f, 0.0f);




        }

            if (Input.GetKey(KeyCode.A))
            {

            TrueVelocity -= new Vector3(Velocity * Time.deltaTime, 0.0f, 0.0f);


            }

        }



        void drivter() {




            Velocity = Velocity - Dump;

            if (Velocity == 0) {


                Dump = 0;
            Velocity = 0;


            }






    }

    void Bombing() {



        if (Input.GetKeyDown(KeyCode.Space))
        {

        



        }






        }

    }

