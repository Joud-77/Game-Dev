using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Vector3 bulletSpawnPoint;
    public GameObject bulletPrefab;


    void Update()
    {

        //invoke repeating 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spp();
            InvokeRepeating("Spp", 0.0f, 1.0f);
        }
        //invoke cancel 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();
        }
        
    }

    //methoud for bullets
    void Spp()
        {
            Instantiate(bulletPrefab, bulletSpawnPoint, new Quaternion());
        }
    }