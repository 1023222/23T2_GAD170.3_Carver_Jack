using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Axe : MonoBehaviour
{
    [SerializeField] private GameObject axe;
    [SerializeField] private GameObject particles;

    // Reference to canvas object
    [SerializeField] private TextMeshProUGUI canvasUI;

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
        //Hides Contextual UI Textbox
        canvasUI.enabled = false;

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
        //Displays UI Textbox
        canvasUI.enabled = true;

        //Let it be knownst'th
        Debug.Log("You picked up 'Axe'!");

        //Play the correct AudioSource component
        //pickup.Play();

        //Run the method from Audio Pickup Work Around
        audioPickUpWorkAround.PickUpSound();

        //Switch bool on door to true
        doorAccess.playerHasAxe = true;

        //'Hide' Axe and Particles on 'pickup'
        Destroy(axe);
        Destroy(particles);
    }

    private void OnTriggerExit(Collider other)
    {
        //Remove Contextual UI Textbox
        canvasUI.enabled = false;
        //Destroy axe to remove sound
        Destroy(gameObject);

    }
}
