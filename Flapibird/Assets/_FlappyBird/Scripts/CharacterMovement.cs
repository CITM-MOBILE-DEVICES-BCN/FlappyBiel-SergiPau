using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rigidBody;
    [SerializeField] protected float jumpForce = 7f;
    [SerializeField] protected float maxFallSpeed = -5f;
    [SerializeField] protected float rotationSpeed = 5f;
    [SerializeField] protected float jumpCooldown = 0.2f;
    private float nextJumpTime = 0f;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("character") != 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        GetInput();
    }

    protected void GetInput()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && Time.time >= nextJumpTime)
        {
            Jump();
            nextJumpTime = Time.time + jumpCooldown;
        }
    }

    protected void FixedUpdate()
    {
        BirdRotation();
    }

    protected void Jump()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    protected void BirdRotation()
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