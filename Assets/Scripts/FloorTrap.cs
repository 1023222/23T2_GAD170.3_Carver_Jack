using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorTrap : MonoBehaviour
{
    //Get reference for canvas.
    [SerializeField] private TextMeshProUGUI canvasUI;

    //Reference for death Animation
    [SerializeField] private ParticleSystem deathAnimation;

    //Referencing the Mesh Renderer attached
    private MeshRenderer meshRenderer;
    //Referencing the Audiosource attached
    private AudioSource audioSource;
    //Referencing the second Audiosource attacked
    private AudioSource audioSource2;
    //Create somewhere to slot in the scene loader
    [SerializeField] private GameManager sceneManager;
    //Create a delay time for SceneLoading to allow sounds to persist (lazily)
    private float respawnDelay = 2.0f;
    //Access Player Controller to disable input
    [SerializeField] private PlayerController playerController;



    private void Start()
    {
        //Hide Death UI
        //canvasUI.enable = false;

        //Get Mesh Render component and set it false/'hidden'
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        //Get audiosource component to call on to play sound
        audioSource = GetComponent<AudioSource>();
        audioSource2 = GetComponents<AudioSource>()[1];
    }

    //Runs a method when another collider enters the trigger area (this object)
    private void OnTriggerEnter(Collider other)
    {
        //Show death UI
        //canvasUI.enable = true;

        //Play Death Animation
        deathAnimation.Play();
        //Disable player input
        playerController.canMove = false;
        //Debug log the trap!
        Debug.Log("Spikes! Ouch!");
        //Have the trap 'shoot up' - can't animate lmao.
        meshRenderer.enabled = true;
        //Play the sound!
        audioSource.Play();
        audioSource2.Play();
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
