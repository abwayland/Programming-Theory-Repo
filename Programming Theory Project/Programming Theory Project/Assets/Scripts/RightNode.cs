using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightNode : BaseNode // INHERITANCE
{
    private Vector3 direction = Vector3.right;

    public override Vector3 Direction // INHERITANCE // ENCAPSULATION
    {
        get
        {
            return direction;
        }
    }

}
