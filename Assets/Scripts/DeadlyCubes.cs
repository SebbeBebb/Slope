using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyCubes : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        //Code to kill the player
        //If the player collides with the trigger, then the player dies
        if (other.gameObject.tag == "Player"){
            GameObject.Destroy(other.gameObject);
        }
    }
}
