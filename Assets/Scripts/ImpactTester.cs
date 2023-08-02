using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactTester : MonoBehaviour
{

    //We want to make a script to handle Collision and Trigger detection.
    //When our object impacts another, we want to PRINT TEXT.

    //First collisions...

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch! Collision!");

        //Destroy one of the objects in the collision.

        //Destroy the ground. This code will destroy whatever the gameobject this script is attached to collides with.
        Destroy(collision.gameObject);
    }

    //Then triggers. Remember to select the 'is Trigger' option on the components of the game object!
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger! Ouch!");
    }
}

