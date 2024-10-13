using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class NormalPipe : IPipeBuilder
{
    public int SetPattern()
    {
        Debug.Log("Normal Pipe Pattern Set");
        return 0;
    }

    public void SetSpecialProperty()
    {
        Debug.Log("Normal Pipe Special Property Set");
    }

    public Color SetColor()
    {   
        return Color.white;
    }
}
