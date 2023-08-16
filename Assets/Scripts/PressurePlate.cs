using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PressurePlate : MonoBehaviour
{
    private AudioSource audioSource;

    //Getting wallpiece to 'move'
    [SerializeField] private GameObject wall;

    [SerializeField] private TextMeshProUGUI canvasUI;


    private void Start()
    {
        //Hide UI Textbox
        canvasUI.enabled = false;

        //Get Audiosource component to play sound
        audioSource = GetComponent<AudioSource>();

    }

    //Remember to select the 'is Trigger' option on the components of the game object!
    private void OnTriggerEnter(Collider other)
    {
        //Display UI TextBox
        canvasUI.enabled = true;

        Debug.Log("You feel weight shifting beneath you.");
        //Play the sound!
        audioSource.Play();
        Destroy(wall);
    }

    private void OnTriggerExit(Collider other)
    {
        //Hide UI Textbox
        canvasUI.enabled = false;
    }
}
