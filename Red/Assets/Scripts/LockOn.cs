using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOn : MonoBehaviour
{
    public GameObject player; // Target Object
    public Transform target;

    public float enemyAimSpeed = 5.0f; // Speed at Which Enenmy locks on the Target
    Quaternion newRotation;
    float orientTransform;
    float orientTarget;
    private int distance = 7;

    private void Start()
    {
        if (player != null)
        {
            player = GameObject.Find("Player");
            target = player.GetComponent<Transform>();
        }
    }

    void Update()
    {


            // Flip
            float playerPosX = player.transform.position.x;
            float d = playerPosX - transform.position.x;

            if (d < 0 && d >= -distance)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                GetComponent<SpriteRenderer>().flipY = true;
            }
            else if (d > 0 && d <= distance)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                GetComponent<SpriteRenderer>().flipY = false;
            }

            // Flip END

            orientTransform = transform.position.x;
            orientTarget = target.position.x;
            // To Check on which side is the target , i.e. Right or Left of this Object
            if (orientTransform > orientTarget)
            {
                // Will Give Rotation angle , so that Arrow Points towards that target
                newRotation = Quaternion.LookRotation(transform.position - target.position, -Vector3.up);
            }
            else
            {
                newRotation = Quaternion.LookRotation(transform.position - target.position, Vector3.up);
            }

            // Here we have to freeze rotation along X and Y Axis, for proper movement of the arrow
            newRotation.x = 0.0f;
            newRotation.y = 0.0f;

            // Finally rotate and aim towards the target direction using Code below
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * enemyAimSpeed);

            // Another Alternative
            // transform.rotation = Quaternion.RotateTowards(transform.rotation,newRotation, Time.deltaTime * enemyAimSpeed);
        }
    
}
