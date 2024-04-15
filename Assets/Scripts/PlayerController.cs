using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody playerRB;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float startSpeed;
    [SerializeField]
    float timer;
    float speedCounter;
    void Start(){
        
    }
    // Update is called once per frame
    void Update()
    {
        //Speeds up the player for a set amount of frames
        if (speedCounter <= timer){
            playerRB.AddForce(Vector3.forward*startSpeed);
        }
        speedCounter+=1;
        //Player input to go left
        if(Input.GetKey(KeyCode.A)){
            playerRB.AddForce(Vector3.left*moveSpeed);
        }
        //Player input to go right
        if(Input.GetKey(KeyCode.D)){
            playerRB.AddForce(Vector3.right*moveSpeed);
        }
    }
}
