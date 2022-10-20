using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //The camera's position should be in the same position as the car.
    [SerializeField] GameObject ThingToFollow;
    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + new Vector3(0,0,-10);
    } 
}
