using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndRoom : MonoBehaviour
{
    //Get a reference to A TextMeshPro object
    [SerializeField] private TextMeshProUGUI winText;

    [SerializeField] private CrystalSpawner crystalSpawner;

    private void Start()
    {
        //Disable the textbox on start so it's not showing.
        winText.enabled = false;
    }

    //Runs method when any object with a collider collides with it.
    private void OnTriggerEnter(Collider other)
    {
        crystalSpawner.InstantiateCrystal();

        //Enable (show) text box.
        winText.enabled = true;
        Debug.Log("You win.");
    }

}