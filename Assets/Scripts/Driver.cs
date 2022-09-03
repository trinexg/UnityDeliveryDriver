using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //SerializeField will allow us to edit the variable in Unity
    [SerializeField] float steeringVelocity = 300;
    [SerializeField] float movementSpeed = 17;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steeringVelocity * Time.deltaTime;
        float movementAmount = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,movementAmount,0);
    }
}
