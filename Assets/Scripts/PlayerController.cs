using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody playerRB;
    [SerializeField]
    float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            playerRB.AddForce(Vector3.left*moveSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            playerRB.AddForce(Vector3.right*moveSpeed);
        }

    }
}
