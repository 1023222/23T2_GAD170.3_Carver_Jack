using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    //Get a reference to A TextMeshPro object
    [SerializeField] private TextMeshPro doorText;

    //Make a condition for getting through.
    [SerializeField] public bool playerHasAxe;

    private void Start()
    {
        //Disable the textbox on start so it's not showing.
        doorText.enabled = false;

        playerHasAxe = false;
    }

    //Runs method when any object with a collider collides with it.
    private void OnTriggerStay(Collider other)
    {
        //Testing it runs the method.
        //Debug.Log("You arrive at the makeshift door.");

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (playerHasAxe == true)
            {
                Debug.Log("You break down the makeshift barrier.");
                Destroy(gameObject);
            }
            else
            {
                //Enable (show) text box.
                doorText.enabled = true;
                Debug.Log("You need a way to get through these planks.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Disable the text box
        doorText.enabled = false;
    }
}