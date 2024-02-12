using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amoving : MonoBehaviour
{
    Vector3 forwaed = new Vector3(0, 0, 0.1f);
    Vector3 Backwaed2 = new Vector3(0, 0, -0.1f);
    Vector3 right = new Vector3 (0.1f, 0);
    Vector3 left = new Vector3(-0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Start");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
        

















    }
}
