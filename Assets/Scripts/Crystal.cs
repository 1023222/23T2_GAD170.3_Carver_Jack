using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    //Spin speed
    [SerializeField] private float spinSpeed = 150.0f;

    // Update is called once per frame
    void Update()
    {
        //Spin that bad boy
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

    }
}
