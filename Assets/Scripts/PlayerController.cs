using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 moveInput;


    void Update()
    {
        // Get input from Horizontal and Vertical axes (WASD/Arrow Keys by default)
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
    }


    void FixedUpdate()
    {
        // Apply velocity to the Rigidbody2D
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
