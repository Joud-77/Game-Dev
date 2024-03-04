using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThierdPerson : MonoBehaviour
{
    Transform playerTransform;
    Vector3 cameraRotation;
    float initialCamera;
    float mouseSensitivity = 1;
    public float speed;
    public float rotationSpeed;
    private Vector3 movementDirection;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log(playerTransform.gameObject.name);
        initialCamera = Vector3.Distance(transform.position, playerTransform.position);
        cameraRotation = transform.rotation.eulerAngles;
    }


    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (playerTransform)
        {
            float mouseX = Input.GetAxis("Mouse X");

            if (mouseX != 0)
            {
                cameraRotation.y += mouseX * mouseSensitivity;

            }
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }

            transform.eulerAngles = cameraRotation;
            Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
            transform.position = -cameraLookDirection * initialCamera + playerTransform.position;




        }
    }

    void OnEnable()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void OnDisable()
    {
        //Cursor.lockState = CursorLockMode.None;
    }
}


/*
    [SerializeField]
    private float _mouseSensitivity = 3.0f;

    private float _rotationY;
    private float _rotationX;

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _distanceFromTarget = 0.25f;

    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;

    [SerializeField]
    private float _smoothTime = 0.2f;

    [SerializeField]
    private Vector3 _rotationXMinMax = new Vector3(-10, 50, 10);

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX += mouseY;

        // Apply clamping for x rotation 
        _rotationX = Mathf.Clamp(_rotationX, _rotationXMinMax.x, _rotationXMinMax.y);

        Vector3 nextRotation = new Vector3(_rotationX, _rotationY);

        // Apply damping between rotation changes
        _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
        transform.localEulerAngles = _currentRotation;

        // Substract forward vector of the GameObject to point its forward vector to the target
        transform.position = _target.position - transform.forward * _distanceFromTarget;


        Vector3 rot = playerTransform.rotation.eulerAngles;
            rot.y = cameraRotation.y;
            playerTransform.eulerAngles = rot;
    */