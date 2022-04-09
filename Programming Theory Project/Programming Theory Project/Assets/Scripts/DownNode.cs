using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownNode : BaseNode //Inheritance
{
    private Vector3 direction = Vector3.down;

    public override Vector3 Direction //Inheritance // ENCAPSULATION
    {
        get
        {
            return direction;
        }
    }
}
