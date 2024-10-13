using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PipeFinalProduct 
{
    public void SetColor(GameObject pipe,  Color color)
    {
        return pipe.GetComponent<Renderer>().material.color = color;
    }
}
