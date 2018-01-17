using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject Splayer;
    public int playerAmount = 0;

    // Use this for initialization
    void Start() {



    }

    // Update is called once per frame
    void Update()
    {



        if (playerAmount == 0)
        {
            if (Splayer.GetComponent<Player>().Recording == true)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {

                    Instantiate(Splayer, transform.position, transform.rotation);
                    playerAmount++;

                }

            }
        }
        else {



            Destroy(gameObject);

        }
    }
}

