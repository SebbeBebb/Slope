using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject camera;
    [SerializeField]
    GameObject player;
    void Update() {
        camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3, player.transform.position.z-5);
    }
}
