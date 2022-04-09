using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum NodeState
{
    Open,
    Closed
}
public class BaseNode : MonoBehaviour
{
    private Vector3 direction = Vector3.zero;
    public virtual Vector3 Direction { get; }

    private NodeState currentNodeState = NodeState.Open;
    public NodeState CurrentNodeState
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

    public void ChangeNodeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    public void ChangeNodeColor(Color color)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }

}


