using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDebugger : MonoBehaviour
{
    public float Angltest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 200, Color.blue);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            Debug.DrawRay(hit.transform.position, hit.transform.forward * 200, Color.red);
            if (hit.collider.tag == "mirror")
            {
                Debug.Log(Vector3.Angle(transform.forward, hit.transform.right));
                float inpAngle = Vector3.Angle(transform.forward, hit.transform.right);
                Vector3 castangle = Quaternion.Euler(0, 180- inpAngle, 0) *- hit.transform.right;
                Debug.DrawRay(hit.transform.position, castangle * 200, Color.yellow);
                Debug.DrawRay(hit.transform.position, hit.transform.right * 200, Color.green);
            }
          
            

            //
        }
    }
}
