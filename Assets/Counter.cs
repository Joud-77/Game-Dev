using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
//it's used to count the coins 
int coins = 0;
 //it's just to adjuist the text 
    [SerializeField] TextMeshProUGUI coinsText;
    
 
    public void Count()
    {
        //it's will count every coin that i collect and will add 1 
        coins++;
        coinsText.text = "Coin: " + coins;
        
    }
}
