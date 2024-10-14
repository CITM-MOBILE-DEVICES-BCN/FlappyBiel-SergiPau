using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeY : MonoBehaviour
{
    float speed; 
    float height = 1.0f;

    private Vector3 startPosition;
    void Start()
    {
        speed = Random.Range(1.0f, 3.0f);
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    { 
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
