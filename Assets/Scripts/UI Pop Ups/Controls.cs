using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controls : MonoBehaviour
{
    //Get a reference to A TextMeshPro object
    [SerializeField] private TextMeshPro tutorialText;

    private void Start()
    {
        //Disable the textbox on start so it's not showing.
        tutorialText.enabled = false;
    }
    
    //Runs method when any object with a collider collides with it.
    private void OnTriggerEnter(Collider other)
    {
        //Enable (show) text box.
        tutorialText.enabled = true;
        Debug.Log("Movement: WASD. Left shift to Sprint. Space to Jump. Mouse to look around.");
    }

    private void OnTriggerExit(Collider other)
    {
        //Disable the text box
        tutorialText.enabled = false;
    }
}