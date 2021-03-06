﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class Player : MonoBehaviour
{

     List<string> saveAction = new List<string>();
     List<float> saveTime = new List<float>();
    List<Vector3> pos = new List<Vector3>();


    public int Killamount = 0;

    float RealTime = 0;
    

    float PlayerPosXS = 0;
    float PlayerPosYS = 3;
    bool SpawndAtStart = true;

    int PlayerAmount = 1;

    int CurrentAction = 0;
    public bool Recording = true;
    public float Playtime = 0;

    float Playerspeed = 10;

    float Velocity = 0;
    float TrueVelocity;

    bool Direction = true;
    bool ready = true;
    bool RePlay = false;

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
    private GameObject player;


    //array


    //public SaveAction[] saveAction = new SaveAction[100];




    // Use this for initialization
    void Start()

    {
        

        DontDestroyOnLoad(gameObject);


        //saveAction = new SaveAction[101];
        CurrentTime = MaxTime;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(RealTime);
        Debug.Log(RePlay);



       // Debug.Log(Killamount);
        Killamount = GetComponent<Scoring>().tValue;

        if (Direction){

            TrueVelocity += Velocity * Time.deltaTime/2;

        }
        else{

            TrueVelocity -= Velocity * Time.deltaTime /2;

        }

        



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





        if (Recording)
        {


            if (Killamount >= 10)
            {

                transform.position = new Vector3(PlayerPosXS, PlayerPosYS, 0);
                TrueVelocity = 0;
                pos.Add(transform.position);
                RealTime = Playtime;
                Playtime = 0;
                GetComponent<Scoring>().tValue = 0;
                GetComponent<Scoring>().cValue = 0;
                Killamount = 0;
                Recording = false;

                // SceneManager.LoadScene("Replay");
            }

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
                Direction = true;
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


                Direction = false;
                saveAction.Add("A");
                    saveTime.Add(Playtime);
                    pos.Add(transform.position);
                    Maxlist++;
              
            
            }
        }

        if (!Recording && !RePlay) {
            Time.timeScale = 0;
            GameObject.Find("Player 2/Score/Pause").SetActive(true);
            if (Input.GetKey("return"))
            {
                RePlay = true;
                GameObject.Find("Player 2/Score/Pause").SetActive(false);
                SceneManager.LoadScene("Replay");
                Time.timeScale = 1;
                
            }
                


        }


       if (!Recording && RePlay)
            {

            GameObject.Find("Player 2/Score/Return").SetActive(true);
            if (Input.GetKey(KeyCode.Escape))
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Menu");
            }


            Debug.Log(RealTime);


            if (Playtime >= RealTime || Killamount >= 10)
            {
                transform.position = new Vector3(PlayerPosXS, PlayerPosYS, 0);
                TrueVelocity = 0;
                Playtime = 0;
                GetComponent<Scoring>().tValue = 0;
                GetComponent<Scoring>().cValue = 0;
                Killamount = 0;
                SceneManager.LoadScene("Replay");



               



            }

            for (int i = 0; i < Maxlist; i++)
                {


  



                if (saveTime[i] <= Playtime + 0.01f && saveTime[i] >= Playtime - 0.01)
                    {
                        Debug.Log("Time");
                    

                    if (saveAction[i] == ("A"))
                        {


                         Debug.Log("A");
                        Direction = false;
                        TrueVelocity -= Velocity * Time.deltaTime;
                        transform.eulerAngles = new Vector3(0, 180, 0);


                        }
                        if (saveAction[i] == "D")
                        {

                         Debug.Log("D");
                        Direction = true;
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
 

  