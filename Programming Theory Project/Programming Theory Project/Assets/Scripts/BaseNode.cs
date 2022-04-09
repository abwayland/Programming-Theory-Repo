using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum NodeState
{
    Open,
    Closed
}
public class BaseNode : MonoBehaviour // INHERITANCE
{
    private Vector3 direction = Vector3.zero;
    public virtual Vector3 Direction { get; } // INHERITANCE // ENCAPSULATION

    private NodeState currentNodeState = NodeState.Open;
    public NodeState CurrentNodeState // ENCAPSULATION
    {
        get
        {
            return currentNodeState;
        }
        set
        {
            currentNodeState = value;
        }
    }

    public void ChangeNodeColor() // POLYMORPHISM
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    public void ChangeNodeColor(Color color) // POLYMORPHISM
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }

}


