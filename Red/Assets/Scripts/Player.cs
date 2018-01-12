using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour {



    
    float Playerspeed = 10;

    float Velocity = 0;
    float TrueVelocity ;
    
    bool Direction;
    bool ready = true;
    float MaxTime = 10;
    float CurrentTime = 0;

    //Bombe
    int MaxBomb = 3;
    int existingBombs = 0;
    public GameObject BSprite;


   

    


    // Use this for initialization
    void Start () {
       
           
        CurrentTime = MaxTime;

    }

    // Update is called once per frame
    void Update() {

        if (!ready) {

            float timer = 0.6f;
            CurrentTime = CurrentTime - timer;
            
            if (CurrentTime <= 0) {
                CurrentTime = MaxTime;

                ready = true;
            }
        }

      //  for (int i = 0; i < MaxBomb; i++) {


            Velocity = Playerspeed;
            transform.position = new Vector3(TrueVelocity, transform.position.y, 0);
        if (existingBombs <= MaxBomb)
        {
            if (Input.GetKeyDown(KeyCode.Space) && ready)


            {
                Instantiate(BSprite, transform.position, transform.rotation);
                ready = false;



            }
        }

      //  }


        if (Input.GetKey(KeyCode.D)) {


            TrueVelocity += Velocity * Time.deltaTime;
            transform.eulerAngles = new Vector3(0,0,0) ;



        }

            if (Input.GetKey(KeyCode.A))
            {

            TrueVelocity -= Velocity * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

        }

}

 

  