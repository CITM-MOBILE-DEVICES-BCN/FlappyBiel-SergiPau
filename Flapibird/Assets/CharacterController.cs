using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
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
            rigidBody.velocity = Vector2.zero;
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
       }

        float angle = Vector3.Angle(Vector3.right, rigidBody.velocity);
        if (rigidBody.velocity.y < 0)
        {
            angle = -angle;
        }
           
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
