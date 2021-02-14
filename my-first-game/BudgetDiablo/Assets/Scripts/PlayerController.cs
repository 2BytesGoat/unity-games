using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController: MonoBehaviour
{
    Camera cam;

    public LayerMask groundLayer;
    public NavMeshAgent playerAgent;
    Vector3 position;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            playerAgent.SetDestination(GetPointUnderCursor());
        }
    }

    private Vector3 GetPointUnderCursor()
    {
        RaycastHit hitPosition;
        Ray mouserWorldPosition = cam.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(mouserWorldPosition, out hitPosition, 10000, groundLayer);
        return hitPosition.point;
    }
}
