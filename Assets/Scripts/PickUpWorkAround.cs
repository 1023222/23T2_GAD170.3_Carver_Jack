using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWorkAround : MonoBehaviour
{
    //Getting Access to the Axe object and it's stuffsh.
    [SerializeField] private GameObject axe;
    private AudioSource pickup;

    //Using the audiosource on this object for iNsUrAnCe
    private AudioSource audioSource;

    private void Start()
    {
        //Calling the second audio source component from the axe game object,
        pickup = axe.GetComponents < AudioSource>()[1];

        //
        audioSource = GetComponent<AudioSource>();
    }

    //The method to actually play the sound.
    public void PickUpSound()
    {
        //Testing it runs the method.
        //Debug.Log("It worked!!!");
        //Plays the second audiosource from the axe object. DIDN'T WORK AAA
        //pickup.Play();

        //Just play the audiosource from this object instead of the axe's.
        audioSource.Play();
    }
}
