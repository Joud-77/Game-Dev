using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Vector3 bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;


    void Update()
    {

        //invoke repeating 
        if (Input.GetKeyDown(KeyCode.T))
        {
            Spp();
            InvokeRepeating("Spp", 0.0f, 0.5f);
        }
        //invoke cancel 
        if (Input.GetKeyUp(KeyCode.T))
        {
            CancelInvoke();
        }


    }

    //methoud for bullets
    void Spp()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }


}