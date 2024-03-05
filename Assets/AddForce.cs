using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody m_rig;
    // Start is called before the first frame update
    void Start()
    {
        m_rig = GetComponent<Rigidbody>();
        m_rig.AddForce(Vector3.up * 30, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
