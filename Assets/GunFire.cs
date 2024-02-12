using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Vector3 bulletSpawnPoint;
    public GameObject bulletPrefab;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint, new Quaternion());
           Destroy(bullet,1.0f);
        }
    }
}