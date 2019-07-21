using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicModule : MonoBehaviour
{
    public int pointsAtThisStep;
    public GameObject inpG;

    public Vector3 castangle;
    public float inpAngle;

    // Transform lastHit;
    //  Transform currHit;
    Vector3 hitpos;
    Vector3 curpos;
    Vector3 curlastpos;
    Quaternion hitrot;
    Vector3 hitlastpos;
    Quaternion hitlastrot;
    Quaternion curlastrot;
    Quaternion currot;

    public GameObject hited;
    public Vector3 hitpoint;

    public virtual void SetInpAng (float a){
        inpAngle = a;
    }

    public virtual void HandleRayMod() {
        
    }
  


    private void Start()
    {

     //lastHit = transform;
    // Debug.Log(RayRenderer);
    }
     public void Update()
    {
        curpos = transform.position;
        currot = transform.rotation;
        castangle = Quaternion.Euler(0, inpAngle, 0) * transform.forward;

        Debug.DrawRay(transform.position, castangle*1000,Color.blue);
        //Debug.DrawRay(transform.position, transform.forward * 10, Color.yellow);
        RaycastHit hit;
            if (Physics.Raycast(transform.position, castangle, out hit, 1000))
            {
              hitpos= hit.transform.gameObject.transform.position;
              hitrot= hit.transform.gameObject.transform.rotation;
            if (hitpos != hitlastpos||hitrot!=hitlastrot||curpos!=curlastpos||currot!=curlastrot)
            {
                hitpoint = hit.point;
                BasicModule[] module = hit.transform.gameObject.GetComponents<BasicModule>();
                 if (module.Length > 0)
                  {
                    float horang = Vector3.Angle(hit.transform.right, castangle);
                       module[0].SetInpAng(90-horang);

                  }


                hited = hit.transform.gameObject;
                 HandleRayMod();
            }
            hitlastpos = hitpos;
            hitlastrot = hitrot;
             }

        // Debug.Log(currHit.position.x + "___" + lastHit.position.x);

        curlastpos = curpos;
        curlastrot = currot;
    }
}
