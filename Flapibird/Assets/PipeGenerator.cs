using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public float timeToRepeat = 2;
    public GameObject[] pipePrefab;
    void Start()
    {
        InvokeRepeating("CreatePipes", 1, timeToRepeat);
    }

    public void CreatePipes()
    {
        Instantiate(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
    }
}
