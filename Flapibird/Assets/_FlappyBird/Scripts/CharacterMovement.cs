using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] float jumpForce = 7f;
    [SerializeField] float maxFallSpeed = -5f;
    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] float jumpCooldown = 0.2f;
    private float nextJumpTime = 0f;

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && Time.time >= nextJumpTime)
        {
            Jump();
            nextJumpTime = Time.time + jumpCooldown;
        }
    }

    private void FixedUpdate()
    {
        BirdRotation();
    }

    void Jump()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void BirdRotation()
    {
        float angle = 0;

        if (rigidBody.velocity.y < 0)
        {
            angle = Mathf.Lerp(0, -90, -rigidBody.velocity.y / 10);
        }
        else if (rigidBody.velocity.y > 0)
        {
            angle = Mathf.Lerp(0, 25, rigidBody.velocity.y / 10);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle), Time.deltaTime * rotationSpeed);

        if (rigidBody.velocity.y < maxFallSpeed)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, maxFallSpeed);
        }
    }
}