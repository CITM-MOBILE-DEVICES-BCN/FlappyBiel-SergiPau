using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class InvertionPipe : IPipeBuilder
{
    private GameObject pipePrefab;
    private GameObject pipeInstance;
    private Vector3 position;
    private Quaternion rotation;

    public InvertionPipe(GameObject pipePrefab, Vector3 position, Quaternion rotation)
    {
        this.pipePrefab = pipePrefab;
        this.position = position;
        this.rotation = rotation;
        pipeInstance = GameObject.Instantiate(pipePrefab, position, rotation);
    }

    public void SetSpecialProperty()
    {
        for (int i = 0; i < pipeInstance.transform.childCount; i++)
        {
            if (pipeInstance.transform.GetChild(i).CompareTag("Score"))
            {
                pipeInstance.transform.GetChild(i).tag ="ScoreInvert";
            }
        }
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
                pipeInstance.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }

    }
    public GameObject GetPipe()
    {
        return pipeInstance;
    }
}
