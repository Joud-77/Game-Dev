using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Text : MonoBehaviour
{
    public Text countText;
    public int coinNum;
    public Text WhateverTextThingy;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 2f;
    private float timeWhenDisappear;

    void Start()
    {

    }
    public void EnableText()
    {
        WhateverTextThingy.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (WhateverTextThingy.enabled && (Time.time >= timeWhenDisappear))
        {
            WhateverTextThingy.enabled = false;
        }
    }
}
