using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawner : MonoBehaviour
{

    [SerializeField] private GameObject crystalPrefab;

    [SerializeField] private ParticleSystem crystalSpawnParticles;

    public void InstantiateCrystal()
    {
        StartCoroutine(waitSeconds(3f));
        crystalSpawnParticles.Play();
    }

    IEnumerator waitSeconds(float seconds)
    {
        yield return new WaitForSeconds(3f);
        Instantiate(crystalPrefab);
        crystalSpawnParticles.Pause();
    }

}
