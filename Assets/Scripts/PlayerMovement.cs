using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Hareket Ayarları")]
    public float moveSpeed = 6.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 2.0f;

    private CharacterController _controller;
    private bool _isGrounded;
    private Vector3 _velocity;
    private bool _isJumping = false;

    [Header("Zemin Kontrolü")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    void Move()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2.0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetAxis("Sprint") != 0.0f)
        {
            _controller.Move(move * (moveSpeed + 10) * Time.deltaTime);
        }
        else
        {
            _controller.Move(move * moveSpeed * Time.deltaTime);
        }

        if (_isJumping && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
            _isJumping = false;
        }

        _velocity.y += gravity * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);
    }

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            _isJumping = true;
        }
        Move();
    }

    private void FixedUpdate()
    {
    }
}
