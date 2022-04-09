using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpNode : BaseNode // INHERITANCE
{
    private Vector3 direction = Vector3.up;

    public override Vector3 Direction // INHERITANCE // ENCAPSULATION
    {
        get
        {
            return direction;
        }
    }
}