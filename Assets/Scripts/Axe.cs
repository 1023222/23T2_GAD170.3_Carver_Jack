using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    //AudioSource 2
    private AudioSource pickup;

    //Spin speed
    [SerializeField] private float spinSpeed = 150.0f;

    //Creating a reference space for my other object to access it's script's methods.
    [SerializeField] private PickUpWorkAround audioPickUpWorkAround;

    //Creating a reference space for my door to access it's boolean.
    [SerializeField] private Door doorAccess;

        private void Start()
    {
        //Declare the correct audiosource component. It automatically makes a list when adding components, so we need to get the right one in the list.
        pickup = GetComponents<AudioSource>()[1];
    }
        private void Update()
    {
        //Spin that bad boy
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
        private void OnTriggerEnter(Collider other)
    {
        //Let it be knownst'th
        Debug.Log("You picked up 'Axe'!");

        //Play the correct AudioSource component
        //pickup.Play();

        //Run the method from Audio Pickup Work Around
        audioPickUpWorkAround.PickUpSound();

        //Switch bool on door to true
        doorAccess.playerHasAxe = true;

        //Destroy the gameobject
        Destroy(gameObject);
    }
}
