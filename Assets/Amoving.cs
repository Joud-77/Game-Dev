using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.InputSystem;

public class Amoving : MonoBehaviour
{

    private Animator anime;
    private bool isMoving;
    private bool isJumping;
    [SerializeField] float JumpForce = 10;

    public Rigidbody rbMove;
    //rigid body viloctiy 
    Vector3 forwaed = new Vector3(0, 0, 0.25f);
    Vector3 Backwaed2 = new Vector3(0, 0, -0.25f);
    Vector3 right = new Vector3(0.25f, 0);
    Vector3 left = new Vector3(-0.25f, 0, 0);

    void Start()
    {
        Debug.LogWarning("Start");

        rbMove = GetComponent<Rigidbody>();
        anime = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        bool moving = false;

        // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
        if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            rbMove.velocity += forwaed;
            moving = true;
            anime.SetBool("isMoving", true);
        }
        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            rbMove.velocity += Backwaed2;
            moving = true;
            anime.SetBool("isMoving", true);
        }
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            rbMove.velocity += right;
            moving = true;
            anime.SetBool("isMoving", true);
        }
        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            rbMove.velocity += left;
            moving = true;
            anime.SetBool("isMoving", true);
        }
        //for jumping 
        if (Input.GetKeyUp(KeyCode.Space) && !isJumping)
        {
            rbMove.AddForce(Vector3.up * JumpForce);
            moving = true;
            anime.SetBool("isJumping", true);
        }
        if (moving == false)
        {
            rbMove.velocity = new Vector3(0, rbMove.velocity.y, 0);
            anime.SetBool("isMoving", false);
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(rbMove.velocity);
        }


    }
}



