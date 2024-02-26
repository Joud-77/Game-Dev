using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    #region Variables

    private Vector3 _offset;
    [SerializeField] private Transform target;

    #endregion

    #region Unity callbacks

    private void Awake()
    {
        _offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        if (target)
        {
            Vector3 targetPosition = target.position + _offset;
            transform.position = targetPosition;
        }
    }


    //3d camera person 
    #endregion
}