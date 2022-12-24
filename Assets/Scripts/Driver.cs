using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //SerializeField will allow us to edit the variable in Unity
    [SerializeField] float steeringVelocity = 300;
    [SerializeField] float movementSpeed = 20;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;
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

    void OnCollisionEnter2D(Collision2D other)
    {
        movementSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D pawn)
    {
        if(pawn.tag == "Boost")
        {
            movementSpeed = boostSpeed;
        }
    }
}
