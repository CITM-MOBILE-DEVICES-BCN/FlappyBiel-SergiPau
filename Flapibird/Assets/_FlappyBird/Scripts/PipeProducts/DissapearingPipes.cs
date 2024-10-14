using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DissapearingPipes : IPipeBuilder
{
    private GameObject pipePrefab;
    private GameObject pipeInstance;
    private Vector3 position;
    private Quaternion rotation;

    public DissapearingPipes(GameObject pipePrefab, Vector3 position, Quaternion rotation)
    {
        this.pipePrefab = pipePrefab;
        this.position = position;
        this.rotation = rotation;
        pipeInstance = GameObject.Instantiate(pipePrefab, position, rotation);
    }
    public void SetPattern()
    {
        Debug.Log("Normal Pipe Pattern Set");
    }

    public void SetSpecialProperty()
    {
       for (int i = 0; i < pipeInstance.transform.childCount; i++)
       {
            if (pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>() != null)
            {
               pipeInstance.transform.GetChild(i).gameObject.AddComponent<PipeDissapear>();
            }
       }
    }

    public void SetColor()
    {
        if (pipeInstance == null)
        {
            Debug.LogError("pipeInstance is not instantiated. Call GetPipe() before SetColor().");
            return;
        }

        for (int i = 0; i < pipeInstance.transform.childCount; i++)
        {
            if (pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>() != null)
            {
                pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.black;
            }
        }

    }
    public GameObject GetPipe()
    {
        return pipeInstance;
    }
}
