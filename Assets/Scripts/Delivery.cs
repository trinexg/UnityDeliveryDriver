using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Check Works!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            Debug.Log("Picked up a package!");
        }

        if(other.tag == "Customer")
        {
            Debug.Log("Package Delivered!");
        }
    }
}
