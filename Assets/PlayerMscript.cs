using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMscript : MonoBehaviour
{
    private Animator anime;
    [SerializeField]
    private float Speed = 10f;
    private PlayerAction playerAction;
    private Rigidbody rigi;
    private Vector2 isMoveing;

    [SerializeField]
    private float jumpForce = 20f;

    private void Update()
    {
        if (playerAction.GamePlaye.Jump.WasPerformedThisFrame())
        {
            rigi.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anime.SetBool("isJumping", true);
        }
        else
        {
            anime.SetBool("isJumping", false);
        }
    }
    private void Awake()
    {
        playerAction = new PlayerAction();
        rigi = GetComponent<Rigidbody>();

        if (rigi == null)
        {
            Debug.LogError("RigidBody is Null for Player!");

        }

    }

    private void OnEnable()
    {
        playerAction.GamePlaye.Enable();
    }

    private void OnDisable()
    {
        playerAction.GamePlaye.Disable();
    }
    void Start()
    {
        anime = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isMoveing = playerAction.GamePlaye.move.ReadValue<Vector2>();
        rigi.velocity = new Vector3(isMoveing.x * Speed, rigi.velocity.y, isMoveing.y * Speed);
        anime.SetBool("isMoving", isMoveing != Vector2.zero);
        transform.rotation = Quaternion.LookRotation(rigi.velocity);


    }
}
