using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] float jumpForce = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            Jump();
       }
      

    }
    private void FixedUpdate()
    {
        BirdRotation();
    }
    void Jump()
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    void BirdRotation()
    {
        float angle = 0;
        if (rigidBody.velocity.y < 0)
        {
            angle = Mathf.Lerp(0, -45, -rigidBody.velocity.y / 10);
        }
        else if (rigidBody.velocity.y > 0)
        {
            angle = Mathf.Lerp(0, 45, rigidBody.velocity.y / 10);
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
