using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colorcourntin : MonoBehaviour
{
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColor());
    }



    IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            color = UnityEngine.Random.ColorHSV();
            GetComponent<Renderer>().material.color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
