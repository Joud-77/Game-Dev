using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;

    }
}

/*public LayerMask m_Mask = -1;

//Assign a GameObject in the Inspector that you want to test collisions with
public GameObject m_MyGameObject;
//This is the Collider of the GameObject you assign in the Inspector
Collider m_OtherGameObjectCollider;

void Start()
{
    //Fetch the Collider from the GameObject you assign in the Inspector
    m_OtherGameObjectCollider = m_MyGameObject.GetComponent<Collider>();
}

void FixedUpdate()
{
    //Set the direction as forward
    Vector3 direction = transform.TransformDirection(Vector3.forward);

    //Use Physics to calculate the raycast
    //Uses your GameObject's original position, the direction (above), the max distance from your GameObject, and the LayerMask value to calculate raycast.
    //Also tells it to ignore trigger colliders using QueryTriggerInteraction
    if (Physics.Raycast(transform.position, direction, m_MaxDistance, m_Mask.value, QueryTriggerInteraction.Ignore))
        print("There is something in front of the object!");
}

void Update()
{
    //Press space to turn the other GameObject's trigger status on and off
    if (Input.GetKeyDown(KeyCode.Space))
    {
        //Test if the trigger collisions are ignored by turning the GameObject's trigger collider on and off
        m_OtherGameObjectCollider.isTrigger = !m_OtherGameObjectCollider.isTrigger;
    }
}*/
