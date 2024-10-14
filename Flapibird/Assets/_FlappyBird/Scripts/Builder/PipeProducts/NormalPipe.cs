using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        pipeInstance = GameObject.Instantiate(pipePrefab, position, rotation);
    }

    public void SetSpecialProperty()
    {
        Debug.Log("Normal Pipe Special Property Set");
    }

    public void SetColor()
    {
        if (pipeInstance == null)
        {
            return;
        }

        for (int i = 0; i < pipeInstance.transform.childCount; i++)
        {
            if (pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>() != null)
            {
                pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.white;
            }
        }

    }
    public GameObject GetPipe()
    {
        return pipeInstance;
    }
}
