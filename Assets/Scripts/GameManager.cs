using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string start = "Game";

    public void LevelStart()
    {
        SceneManager.LoadScene(start);
    }
}
