using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
   private int coin = 0;
    public TextMeshProUGUI coinText;
   private void OnCollisionEnter(Collision col)
   {
       if(col.gameObject.tag=="Player")
       {
            coin++;
            coinText.text="coins:"+ coin.ToString();
            Debug.Log(coin);
            Destroy(gameObject);
            
       } 

   }
}
