using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    float Xmove;
    float playerSpeed = 40;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        //jump = false;
        Xmove = Input.GetAxisRaw("Horizontal") * playerSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }  
    }
    private void FixedUpdate()
    {
        controller.Move(Xmove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
