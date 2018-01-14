using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explosion : MonoBehaviour
{
    float Health = 1f;
    float liveTimer = 1f;
    float explosionTime = 15f;
    int Damage = 1;

    private GameObject player;
    public AudioClip clip;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        explosionTime = explosionTime - liveTimer;

        if (explosionTime <= 0)
        {
            explosionTime = 0;
            Destroy(gameObject);

        }

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        player.GetComponent<AudioSource>().PlayOneShot(clip);

        if (col.gameObject.tag == "Civilian")
        {
            int enemyHealth = col.gameObject.GetComponent<NPC>().health;
            enemyHealth = enemyHealth - Damage;

            if (enemyHealth <= 0)
            {
                Destroy(col.gameObject);
            }
        }

        if (col.gameObject.tag == "Terrorist")
        {
            int enemyHealth = col.gameObject.GetComponent<Terrorist>().health;
            enemyHealth = enemyHealth - Damage;

            if (enemyHealth <= 0)
            {
                Destroy(col.gameObject);
            }
        }

        if (col.gameObject.tag == "Structure" && col.gameObject.GetComponent<Structures>().destroyable)
        {
            col.gameObject.GetComponent<Structures>().health--;

            if (col.gameObject.GetComponent<Structures>().health <= 0)
            {
                Destroy(col.gameObject);
            }
        }
    }
}