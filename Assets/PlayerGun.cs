using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{

    public float dmage = 10f;
    public float range = 100f;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward);
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();
        }
    }

    void Shoot()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {

            Debug.Log(hit.transform);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(dmage);
            }
        }
    }
}
