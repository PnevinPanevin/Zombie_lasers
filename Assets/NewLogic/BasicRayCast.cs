using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRayCast : MonoBehaviour
{
    public int pointsAtStep;
    
    public float castAngle = 0;
    public RaycastHit BasicRaycast (float castangle)
    {
        Vector3 angle = Quaternion.Euler(0, castangle, 0) * transform.forward;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, angle, out hit, 1000))
        {
            return hit;
        }
            return hit;
    }

    public virtual void HandleInput(LineRenderer renderer, int pointToCtrl)
    {

    }
 
}
