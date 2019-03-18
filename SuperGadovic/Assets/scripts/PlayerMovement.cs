using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D controller;
    public float runspeed = 40f;
    float horizontalMove = 0f;
    bool isjumping = false;
    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        if(Input.GetButtonDown("Jump"))
        {
            isjumping = true;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isjumping);
        isjumping = false;
        
    }
}
