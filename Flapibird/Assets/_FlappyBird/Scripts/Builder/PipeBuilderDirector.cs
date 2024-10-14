using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBuilderDirector 
{
    public void Construct(IPipeBuilder builder)
    {
        builder.SetSpecialProperty();
        builder.SetColor();
    }

}
