using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class MovingPipe : IPipeBuilder
{
    private GameObject pipePrefab;
    private GameObject pipeInstance;
    private Vector3 position;
    private Quaternion rotation;

    public MovingPipe(GameObject pipePrefab, Vector3 position, Quaternion rotation)
    {
        this.pipePrefab = pipePrefab;
        this.position = position;
        this.rotation = rotation;
        pipeInstance = GameObject.Instantiate(pipePrefab, position, rotation);
    }

    public void SetSpecialProperty()
    {
        pipeInstance.AddComponent<MovePipeY>();
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
                pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
    public GameObject GetPipe()
    {
        return pipeInstance;
    }
}