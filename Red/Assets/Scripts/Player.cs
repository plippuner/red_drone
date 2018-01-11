using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour {



    
    float Playerspeed = 10;

    float Velocity = 0;
    Vector3 TrueVelocity;
    
    bool Direction;

    //Bombe
    int MaxBomb = 3;
   int existingBombs = 0;
    public GameObject BSprite;



    


    // Use this for initialization
    void Start () {

        

    }

    // Update is called once per frame
    void Update() {



      //  for (int i = 0; i < MaxBomb; i++) {


            Velocity = Playerspeed;
            transform.position = TrueVelocity;
        if (existingBombs <= MaxBomb)
        {
            if (Input.GetKeyDown(KeyCode.Space))


            {
                Instantiate(BSprite, transform.position, transform.rotation);
                
            }
        }

      //  }


        if (Input.GetKey(KeyCode.D)) {


            TrueVelocity += new Vector3(Velocity * Time.deltaTime, 0.0f, 0.0f);




        }

            if (Input.GetKey(KeyCode.A))
            {

            TrueVelocity -= new Vector3(Velocity * Time.deltaTime, 0.0f, 0.0f);


            }

        }

}

 

  