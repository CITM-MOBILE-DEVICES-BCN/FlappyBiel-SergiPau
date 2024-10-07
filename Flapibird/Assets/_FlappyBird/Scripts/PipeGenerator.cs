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
           difficultyManager.onDifficultyIncrease.AddListener(OnDifficultyIncreased);
        }
        //Invoke("CreatePipes", 1);
        StartCoroutine(CreatePipes());
    }


    void OnDifficultyIncreased()
    {
        speed += 0.5f / 3;
        
        if (timeToRepeat >= 2)
        {
            timeToRepeat -= 0.2f;
        }
    }
    IEnumerator CreatePipes()
    {

        GameObject pipe = Instantiate(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
        pipe.GetComponent<PipeObstacle>().speed = speed;
        pipe.GetComponent<PipeObstacle>().difficultyManager = difficultyManager;
        yield return new WaitForSeconds(timeToRepeat);
        StartCoroutine(CreatePipes());
    }

}
