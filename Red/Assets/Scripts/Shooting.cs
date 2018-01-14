using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject Bullet;
    float timer;
    float firerate = 0.5f;
    public AudioClip Shot; 

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       // Invoke("FireEnemyBullet", 1f);
    }

    // Function to firen
    public void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("Player");

        timer += Time.deltaTime;

        if (player != null && timer > firerate)
        {
            GameObject bullet = (GameObject)Instantiate(Bullet);
            GetComponent<AudioSource>().PlayOneShot(Shot);
            bullet.transform.position = transform.position;

            Vector2 direction = player.transform.position - bullet.transform.position;
            bullet.GetComponent<Bullet>().SetDirection(direction);

            timer = 0;
        }
    }
}
