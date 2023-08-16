using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LavaTrap : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI canvasUI;

    //Referencing the Audiosource attached
    private AudioSource audioSource;
    private AudioSource audiosource2;
    //Create somewhere to slot in the scene loader
    [SerializeField] private GameManager sceneManager;
    //Create a delay time for SceneLoading to allow sounds to persist (lazily)
    private float respawnDelay = 2.0f;
    //Access Player Controller to disable input
    [SerializeField] private PlayerController playerController;


    private void Start()
    {
        //Hide Death Text
        //canvasUI.enable = false;

        audioSource = GetComponent<AudioSource>();
        audiosource2 = GetComponents<AudioSource>()[1];
    }

    //Runs a method when another collider enters the trigger area (this object)
    private void OnTriggerEnter(Collider other)
    {
        //Show Death Text
        //canvasUI.enable = true;

        //Disable Player Input
        playerController.canMove = false;

        //Debug log the trap!
        Debug.Log("Lava! Ouch!");

        //Play the sound!
        audioSource.Play();
        audiosource2.Play();

        //Start coroutine to delay scene load
        StartCoroutine(RespawnDelay(respawnDelay));
    }

    private IEnumerator RespawnDelay(float delayTime)
    {

        //Wait for delay time
        yield return new WaitForSeconds(delayTime);

        //'Respawn' the player at the beginning.
        sceneManager.LevelStart();
        Debug.Log("Back to Square 1.");
    }
}
