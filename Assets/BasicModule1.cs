using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicModule1 : MonoBehaviour
{
    public int pointsAtThisStep;
    public GameObject RayRenderer;
    public GameObject inpG;
    public  Vector3 castangle ;
    public float inpAngle;

    Transform lasttrans;
    public Transform currTrans;
   


    public virtual void HandleRayMod(GameObject hited) {
        
    }
  


    private void Start()
    {
        
       //lasttrans = Vector3.zero;
    // Debug.Log(RayRenderer);
    }
     public void Update()
    {
            castangle = Quaternion.Euler(0, inpAngle, 0) * transform.forward;

        Debug.DrawRay(transform.position, castangle*1000,Color.blue);
        Debug.DrawRay(transform.position, transform.forward * 1000, Color.yellow);
        RaycastHit hit;
            if (Physics.Raycast(transform.position, castangle, out hit, 1000))
            {
            //Debug.Log(hit.collider.tag);
               currTrans = hit.transform;
                
                if (currTrans != lasttrans)
                {
               // float horAngle = Vector3.Angle(castangle, hit.transform.gameObject.transform.forward);
                Debug.Log("here");
                
                  //BasicModule[] module = hit.transform.gameObject.GetComponents<BasicModule>();
                  //  if (module.Length > 0)
                  //  {
                  //       module[0].inpAngle = horAngle;

                  //  }
                        

                
               // HandleRayMod(hit.transform.gameObject);

                }
                

        }
        lasttrans = currTrans;

    }
}
