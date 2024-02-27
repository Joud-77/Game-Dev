using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpawnEnamy : MonoBehaviour
{
    public GameObject enmey;
    public Transform enemPoint;
    public float repeatRate = 5;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //create enemy if i entar the trigger 
            InvokeRepeating("SpanwnEnamy", 0.5f, repeatRate);
            //to destroy enemy ever 11 seconds 

            gameObject.GetComponent<CapsuleCollider>().enabled = false;

        }
    }

    void SpanwnEnamy()
    {
        var e = Instantiate(enmey);
        Destroy(e, 11);
    }


}
