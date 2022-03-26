using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    private readonly string stillWalk = "StillWalk";
    private readonly string jump = "Jump";
    private readonly string defend = "Defend";

    public KeyCode JumpKeyCode;
    public KeyCode defendKeyCode;

    private void Awake()
    {
        animator = this.transform.GetChild(0).GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //PlayerInputs();
    }

    void PlayerInputs()
    {
        //Move
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool(stillWalk,true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool(stillWalk,false);
        }
        
        //Jump
        if (Input.GetKey(JumpKeyCode))
        {
            animator.SetTrigger(jump);
        }
        
        //Defend
        if (Input.GetKey(defendKeyCode))
        {
            animator.SetTrigger(defend);
        }
    }
}
