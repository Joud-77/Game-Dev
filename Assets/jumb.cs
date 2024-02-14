using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumb : MonoBehaviour
{
    public float jumpforce = 10f;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void UpdateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
                
            }
    }
}
