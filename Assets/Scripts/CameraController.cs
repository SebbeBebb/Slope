using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject player;
    void Update() {
        //Code for following the player with the camera
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3, player.transform.position.z-5);
    }
}
