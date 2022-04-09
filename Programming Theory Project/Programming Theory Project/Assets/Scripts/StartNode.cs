using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNode : BaseNode
{
    [SerializeField] GameObject orb;
    private Vector3 direction = Vector3.right;

    public override Vector3 Direction
    {
        get
        {
            return direction;
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        orb = Instantiate(orb);
        CurrentNodeState = NodeState.Closed;
        ChangeNodeColor(Color.yellow);
    }
}
