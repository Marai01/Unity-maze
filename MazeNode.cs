using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Available,
    Current,
    Completed
}

// 1x1 node made

public class MazeNode : MonoBehaviour
{
    [SerializeField] GameObject[] walls;
    [SerializeField] MeshRenderer floor;

    public void RemoveWall(int walltoremove)
    {
        walls[walltoremove].gameObject.SetActive(false);
    }

    // colors for the path finding

    public void SetState(NodeState state)
    {
        switch (state)
        {
            case NodeState.Available:
                floor.material.color = Color.white;
                break;
            case NodeState.Current:
                floor.material.color = Color.yellow;
                break;
            case NodeState.Completed:
                floor.material.color = Color.blue;
                break;
        }
    }
}
