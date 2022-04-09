using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScript : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Vector3 direction;
    [SerializeField] BaseNode node;
    [SerializeField] StartNode startNode;

    // Start is called before the first frame update

    void Start()
    {
        startNode = GameObject.FindObjectOfType<StartNode>();
        direction = startNode.Direction;
    }

    // Update is called once per frame
    void Update()
    {
        MoveOrb(direction);  // ABSTRACTION
    }

    private void MoveOrb(Vector3 direction) // ABSTRACTION
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BaseNode>() != null)
        {
            node = other.gameObject.GetComponent<BaseNode>();
        }
    }

    private void FixedUpdate()
    {
        if (node != null)
        {
            float distance = Vector3.Distance(transform.position, node.transform.position);
            if (distance <= 0.05)
            {
                if (node.CurrentNodeState == NodeState.Open) {
                    UpdateOrb(); // ABSTRACTION
                    UpdateNode(); // ABSTRACTION
                }
            }
        }
    }

    void UpdateNode() // ABSTRACTION
    {
        node.CurrentNodeState = NodeState.Closed;
        if (node.GetComponent<StopNode>())
        {
            node.ChangeNodeColor(Color.cyan); // ABSTRACTION // POLYMORPHISM
            Destroy(gameObject);
        }
        else
        {
            node.ChangeNodeColor(); // ABSTRACTION // POLYMORPHISM
        }
    }

    void UpdateOrb() // ABSTRACTION
    {
        transform.position = node.transform.position;
        direction = node.Direction;
    }


}


