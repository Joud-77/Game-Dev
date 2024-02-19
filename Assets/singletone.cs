using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletone : MonoBehaviour
{
    public static singletone Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
            Debug.LogError($"Duplicate singletone!");
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }
}
