using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //SerializeField will allow us to edit the variable in Unity
    [SerializeField] float steeringVelocity = 0.18f;
    [SerializeField] float movementSpeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,steeringVelocity);
        transform.Translate(0,movementSpeed,0);
    }
}
