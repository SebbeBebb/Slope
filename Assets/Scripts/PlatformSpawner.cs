using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] platforms;
    void OnTriggerEnter(Collider other) {
        //Spawns a random platform when the player passes the trigger
        if(other.gameObject.tag == "Player") {
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(transform.position.x,transform.position.y-2,transform.position.z+10),Quaternion.identity);
        }
    }
}
