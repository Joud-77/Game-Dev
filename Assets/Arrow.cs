using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
    }
}
/* private Renderer renderer;

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
 renderer.material.color = Color.white;*/
