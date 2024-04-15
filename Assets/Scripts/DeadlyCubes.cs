using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyCubes : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        //Code to kill the player
        if (other.gameObject.tag == "Player"){
            GameObject.Destroy(other.gameObject);
        }
    }
}
