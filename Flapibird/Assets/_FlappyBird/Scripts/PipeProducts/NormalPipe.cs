using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class NormalPipe : IPipeBuilder
{
    private GameObject pipePrefab;
    private GameObject pipeInstance;
    private Vector3 position;
    private Quaternion rotation;

    public NormalPipe(GameObject pipePrefab, Vector3 position, Quaternion rotation)
    {
        this.pipePrefab = pipePrefab;
        this.position = position;   
        this.rotation = rotation;
    }
    public void SetPattern()
    {
        Debug.Log("Normal Pipe Pattern Set");
    }

    public void SetSpecialProperty()
    {
        Debug.Log("Normal Pipe Special Property Set");
    }

    public void SetColor()
    {   
        pipeInstance.GetComponent<Renderer>().material.color = Color.white;
    }

    public GameObject GetPipe()
    {
        pipeInstance = GameObject.Instantiate(pipePrefab, position, rotation);
        return pipeInstance;
    }
}
