using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopNode : BaseNode //Inheritance
{
    private Vector3 direction = Vector3.zero;

    public override Vector3 Direction //Inheritance // ENCAPSULATION
    {
        get
        {
            return direction;
        }
    }
}