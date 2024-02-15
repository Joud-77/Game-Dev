using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     private int bulletObj = 0;
    public float bulletSpeed = 0.1f;
    //public float life = 3;
    // Start is called before the first frame update

    private void Awake()
    {
        Destroy(gameObject, 1.0f);
        
    }
private void OnCollisionEnter(Collision col)
   {
       if(col.gameObject.tag=="Player")
       {
            bulletObj++;
            Debug.Log(bulletObj);
            Destroy(gameObject);
       } 

   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed;
    }
//shooting the enemy 
    //void OnCollisionEnter(Collision collision)
  //  {
      //  if (collision.transform.tag == "Enemy")
      //  {
         //  collision.gameObject.GetComponent<Enemy>().TakeDamage(5);
          
        //}

       // Destroy(gameObject);
   //}
}
