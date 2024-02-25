using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cos : MonoBehaviour
{
    public float speed;
    public float magnuit;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
        //transform.localScale = new Vector3(SineAmount(), SineAmount(), SineAmount());
    }

    public float SineAmount()
    {
        return (float)(magnuit * Math.Sin(Time.time * speed));
    }
}





