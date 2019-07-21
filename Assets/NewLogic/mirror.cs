using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : BasicRayCast
{
    Vector3 currhitpoint;
    Vector3 lasthitpoint;
    LineRenderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void HandleInput(LineRenderer renderer, int pointToCtrl)
    {
        Renderer = renderer;
        Renderer.positionCount = pointToCtrl + 1;
        Renderer.SetPosition(pointToCtrl, currhitpoint);
    }
    // Update is called once per frame
    void Update()
    {
        currhitpoint = BasicRaycast(castAngle).point;
        if (currhitpoint != lasthitpoint)
        {
           
            //BasicRayCast[] module = BasicRaycast(castAngle).transform.GetComponents<BasicRayCast>();
            //if (module.Length > 0 && Renderer != null)
            //{
            //    module[0].HandleInput(Renderer, Renderer.positionCount);

            //}
        }
        lasthitpoint = currhitpoint;
    }
}
