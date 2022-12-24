using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float DestroyDelay = 1.0f;
    bool hasPackage = false;
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Check Works!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Picked up a package!");
            Destroy(other.gameObject, DestroyDelay);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!");
            hasPackage = false;
        }
    }
}
