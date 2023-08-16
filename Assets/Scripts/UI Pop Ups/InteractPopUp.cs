using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractPopUp : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI canvasUI;
    //Get a reference to A TextMeshPro object

    private void Start()
    {

        //Disable the textbox on start so it's not showing.
        canvasUI.enabled = false;
    }

        //Runs method when any object with a collider collides with it.
    private void OnTriggerStay(Collider other)
    {
        canvasUI.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //Disable the text box
        canvasUI.enabled = false;
    }

}
