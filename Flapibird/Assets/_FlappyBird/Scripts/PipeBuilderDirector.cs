using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBuilderDirector 
{
    public void Construct(IPipeBuilder builder)
    {
        builder.SetPattern();
        builder.SetSpecialProperty();
        builder.SetColor();
    }
}
