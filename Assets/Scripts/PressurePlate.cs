using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private AudioSource audioSource;

    //Getting wallpiece to 'move'
    [SerializeField] private GameObject wall;


    private void Start()
    {
        //Get Audiosource component to play sound
        audioSource = GetComponent<AudioSource>();

    }

    //Remember to select the 'is Trigger' option on the components of the game object!
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You feel weight shifting beneath you.");
        //Play the sound!
        audioSource.Play();
        Destroy(wall);
    }
}
