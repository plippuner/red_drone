
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Player : MonoBehaviour
{

     List<string> saveAction = new List<string>();
     List<float> saveTime = new List<float>();
    List<Vector3> pos = new List<Vector3>();




    float PlayerPosXS = 0;
    float PlayerPosYS = 0;


    int CurrentAction = 0;
    public bool Recording = true;
    public float Playtime = 0;

    float Playerspeed = 4;

    float Velocity = 0;
    float TrueVelocity;

    bool Direction;
    bool ready = true;
    float MaxTime = 10;
    int Maxlist = 0;
    float CurrentTime = 0;
    float CurrentSTime = 0;
    bool TimeReady = false;

    float countdown = 1;
    float TT = 5;

    //Bombe
    int MaxBomb = 3;
    int existingBombs = 0;
    public GameObject BSprite;


    //array


    //public SaveAction[] saveAction = new SaveAction[100];




    // Use this for initialization
    void Start()
    {


        //saveAction = new SaveAction[101];
        CurrentTime = MaxTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (!TimeReady)
        {

            countdown = 1f;
            TT = TT - countdown;

            if (TT <= 0)
            {
                TT = 3;

                TimeReady = true;
            }
        }


        Playtime = Playtime + 0.1f;

        Velocity = Playerspeed;
        transform.position = new Vector3(TrueVelocity, transform.position.y, 0);



        if (Input.GetKeyDown(KeyCode.P))
        {

            transform.position = new Vector3(PlayerPosXS, PlayerPosYS, 0);
            TrueVelocity = 0;
            saveAction.Add("None");
            saveTime.Add(Playtime);
            pos.Add(transform.position);
            Recording = !Recording;
            Playtime = 0;
        }

        if (Recording)
        {


            if (!ready)
            {

                float timer = 0.6f;
                CurrentTime = CurrentTime - timer;

                if (CurrentTime <= 0)
                {
                    CurrentTime = MaxTime;

                    ready = true;
                }
            }

            if (existingBombs <= MaxBomb)

            {
                if (Input.GetKeyDown(KeyCode.Space) && ready)


                {
                    Instantiate(BSprite, transform.position, transform.rotation);
                    
                    saveAction.Add("Space");
                    saveTime.Add(Playtime);


                    Maxlist++;
                    ready = false;



                }
            }


            if (!Input.anyKey)
            {
                if (TimeReady){
                saveAction.Add("None");
                saveTime.Add(Playtime);
                pos.Add(transform.position);
                TimeReady = false;
                }

            }






            if (Input.GetKey(KeyCode.D))
            {

                TrueVelocity += Velocity * Time.deltaTime;
                transform.eulerAngles = new Vector3(0, 0, 0);


               // if (TimeReady){
                    saveAction.Add("D");
                    saveTime.Add(Playtime);
                    pos.Add(transform.position);
                    Maxlist++;
                //    TimeReady = false;
              //  }


            }




            if (Input.GetKey(KeyCode.A))
            {
                TrueVelocity -= Velocity * Time.deltaTime;
                transform.eulerAngles = new Vector3(0, 180, 0);
               // if (TimeReady)
               // {
                    saveAction.Add("A");
                    saveTime.Add(Playtime);
                    pos.Add(transform.position);
                    Maxlist++;
                  //  TimeReady = false;
               // }
            }
        }
       if (!Recording)
            {


                Debug.Log("Play");

                for (int i = 0; i < Maxlist; i++)
                {

                    if (saveTime[i] <= Playtime + 0.01f&& saveTime[i] >= Playtime - 0.01)
                    {
                        Debug.Log("Time");

                        if (saveAction[i] == ("A"))
                        {


                         Debug.Log("A");
                        //transform.position = pos[i];
                         TrueVelocity -= Velocity * Time.deltaTime;
                        transform.eulerAngles = new Vector3(0, 180, 0);


                        }
                        if (saveAction[i] == "D")
                        {

                         Debug.Log("D");
                        //transform.position = pos[i];
                        TrueVelocity += Velocity * Time.deltaTime;
                        transform.eulerAngles = new Vector3(0, 0, 0);


                        }
                        if (saveAction[i] == "None")
                        {

                            Debug.Log("None");
                        //transform.position = pos[i];
                        transform.position = new Vector3(transform.position.x, transform.position.y, 0);



                    }
                        if (saveAction[i] == "Space" )
                        {

                            Debug.Log("Space");
                            Instantiate(BSprite, transform.position, transform.rotation);
                            


                        }


                    }

                }
            }
        
    }
}
 

  