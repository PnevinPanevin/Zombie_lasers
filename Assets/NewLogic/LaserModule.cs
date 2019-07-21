using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserModule : BasicRayCast
{
    Vector3 currhitpoint;
    Vector3 lasthitpoint;
   public  GameObject RS;
   
    // Start is called before the first frame update
    void Start()
    {
       // renderer = RS.GetComponent(typeof(LineRenderer)) as LineRenderer; 

    }

    // Update is called once per frame
    void Update()
    {
        currhitpoint = BasicRaycast(castAngle).point;
        if (currhitpoint != lasthitpoint)
        {
            LineRenderer renderer = RS.GetComponent(typeof(LineRenderer)) as LineRenderer;
            renderer.positionCount = 1;
            renderer.positionCount = 2;
            renderer.SetPosition(1, currhitpoint);
            BasicRayCast[] module = BasicRaycast(castAngle).transform.GetComponents<BasicRayCast>();
            if (module.Length > 0)
            {
                module[0].HandleInput(renderer, renderer.positionCount);

            }
        }
        lasthitpoint = currhitpoint;
    }
}
