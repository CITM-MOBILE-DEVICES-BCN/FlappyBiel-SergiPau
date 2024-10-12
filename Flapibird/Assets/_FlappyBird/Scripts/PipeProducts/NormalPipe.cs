using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class NormalPipe : IPipeBuilder
{
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
        Debug.Log("Normal Pipe Color Set");
    }
}
