using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puse : MonoBehaviour
{
    // Start is called before the first frame update
    public void puse()
    {
        Time.timeScale = 0;
    }


    public void resume()
    {
        Time.timeScale=1;
    }
}
