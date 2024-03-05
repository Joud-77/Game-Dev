using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform B_target;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = B_target.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
