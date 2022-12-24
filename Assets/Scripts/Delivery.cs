using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float DestroyDelay = 1.0f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,0);
    [SerializeField] Color32 noPackageColor = new Color32(1,0,0,0);

    bool hasPackage = false;

    SpriteRenderer spriteRenderer;
    
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //Instantiate Sprite Renderer
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Check Works!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor; //Change the color of the car on package pickup
            Debug.Log("Picked up a package!");
            Destroy(other.gameObject, DestroyDelay);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            spriteRenderer.color = noPackageColor; //Change the color of the car to indicate package delivery 
            Debug.Log("Package Delivered!");
            hasPackage = false;
        }
    }
}
