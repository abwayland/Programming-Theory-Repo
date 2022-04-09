using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopNode : BaseNode
{
    private Vector3 direction = Vector3.zero;

    public override Vector3 Direction
    {
        get
        {
            return direction;
        }
    }
}