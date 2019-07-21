using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Laser : BasicModule
{
    int createdPoint;
    GameObject laserSource;
    int modulePoints;
    // Start is called before the first frame update
    public override void HandleRayMod()
    {
        //Debug.Log(hited.name);
        
        laserSource = transform.Find("RaySource").gameObject;
        RayLaser rayLaser = laserSource.GetComponent<RayLaser>();
        rayLaser.RemovePoints();
        rayLaser.AddPoints(hitpoint);
        pointsAtThisStep = rayLaser.GetIndex();



        BasicModule[] module = hited.GetComponents<BasicModule>();
        if (module.Length > 0)
        {
            //if(Vector3.Angle(hited.transform.forward, castangle) > 90 && Vector3.Angle(hited.transform.right, castangle)>0)
            //{
                module[0].SetInpAng(90-Vector3.Angle(hited.transform.right,castangle));
            //}
            
            

            module[0].pointsAtThisStep = rayLaser.GetIndex() + 1;
            module[0].inpG = laserSource;
            module[0].HandleRayMod();


        }



        // modulePoints =laserSource.GetComponent<RayLaser>().AddPoints(currTrans);
    }



}
