using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 10f;
            break;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);

        if (Input.GetButton("Jump") && controller.isGrounded)
        {
            isJumping = true;
            moveDirection.y += jumpForce;
            //moveDirection.y = (jumpForce - gravity * Time.deltaTime;)
        }
    }
}
