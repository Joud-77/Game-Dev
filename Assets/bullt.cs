using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullt : MonoBehaviour
{
    public float bulletSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed;
    }
}