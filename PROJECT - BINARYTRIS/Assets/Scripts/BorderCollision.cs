using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    [SerializeField] Transform rayOrigin;
    [SerializeField] Transform rayEnd;

    void FixedUpdate()
    {
        RaycastBorder();
    }

    private void RaycastBorder()
    {
        RaycastHit hit;

        if (Physics.Raycast(rayOrigin.position, rayEnd.position, out hit))
        {
            if (hit.transform.tag == "Cube")
            {
                hit.transform.parent.GetComponent<PieceMovement>().stopFall();
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(rayOrigin.position, rayEnd.position);
    }
}
