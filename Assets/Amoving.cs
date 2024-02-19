using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amoving : MonoBehaviour
{
    [SerializeField] float JumpForce = 10;
    public Rigidbody jm;
    //rigid body viloctiy 
    Vector3 forwaed = new Vector3(0, 0, 0.1f);
    Vector3 Backwaed2 = new Vector3(0, 0, -0.1f);
    Vector3 right = new Vector3(0.1f, 0);
    Vector3 left = new Vector3(-0.1f, 0);


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Start");
        jm = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += forwaed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Backwaed2;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += left;
        }
        //for jumping 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jm.AddForce(Vector3.up * JumpForce);
        }
    }


}



