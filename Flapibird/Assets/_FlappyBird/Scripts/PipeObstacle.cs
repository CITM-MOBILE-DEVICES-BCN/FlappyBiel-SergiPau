using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeObstacle : MonoBehaviour
{

    public float speed = 2f;

    public DifficultyManager difficultyManager;

    void Start()
    {
        if (difficultyManager != null)
        {
            difficultyManager.onDifficultyIncrease.AddListener(OnDifficultyIncreased);
        }
      
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }

    void OnDifficultyIncreased()
    {
        speed += 0.5f / 3;
    }

}
