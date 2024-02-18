using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //this refreance for the counter
    private Counter m_counter;

    void Awake()
    {
        m_counter = FindObjectOfType<Counter>();
    }

   private void OnCollisionEnter(Collision col)
   {
       if(col.gameObject.tag=="Player")
       {
        //and this to call the counter and destroy the items .
            m_counter.Count();
            Destroy(gameObject);
            
       } 

   }
}
