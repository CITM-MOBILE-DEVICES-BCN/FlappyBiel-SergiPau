using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public float timeToRepeat = 5;
    public GameObject[] pipePrefab;
    public float speed = 2;
    public DifficultyManager difficultyManager;

    void Start()
    {
        
        if (difficultyManager != null)
        {
           difficultyManager.OnDifficultyIncrease.AddListener(OnDifficultyIncreased);
        }
        Invoke("CreatePipes", 1);
       
    }

    public void CreatePipes()
    {
        GameObject pipe = Instantiate(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
        pipe.GetComponent<PipeObstacle>().speed = speed;
        pipe.GetComponent<PipeObstacle>().difficultyManager = difficultyManager;   

        Invoke("CreatePipes", timeToRepeat);
    }

    void OnDifficultyIncreased()
    {
        speed += 0.5f;
        
        if (timeToRepeat >= 2)
        {
            timeToRepeat -= 0.2f;
        }
    }

}
