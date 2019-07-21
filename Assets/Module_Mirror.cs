using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Module_Mirror : BasicModule
{



    public override void HandleRayMod()
    {
        Debug.Log(hited.name);
        if (inpG != null)
        {
            
             RayLaser rayLaser = inpG.GetComponent<RayLaser>();
             rayLaser.SetPoints(pointsAtThisStep);
             rayLaser.AddPoints(hitpoint);
             pointsAtThisStep = rayLaser.GetIndex();
        }







    }


}



// Update is called once per frame

