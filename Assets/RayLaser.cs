using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayLaser : MonoBehaviour
{
    public int rayId;
   

    //public void ActivateRay()
    //{
       
    //    LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer;
    //   // Ray ray = new Ray();
    //    RaycastHit hit ;
    //    if(Physics.Raycast(transform.position, transform.forward, out hit, 1000)){
    //        if (hit.collider.tag == "module")
    //        {
    //            int angle;
    //            hit.collider.gameObject.transform.GetComponent<BasicModule>().InputRayAt(renderer, angle);
    //        }
    //    }
        
       
    //}

    public int GetIndex()
    {
        LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer;
        int index = renderer.positionCount-1;
        return index;
    }
    public void AddPoints(Vector3 pointpos)
    {
        LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer;
        renderer.positionCount = renderer.positionCount + 1;
        int index = renderer.positionCount-1;
        renderer.SetPosition(index, pointpos);
        

    }
    public void RemovePoints()
    {
        LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer; renderer.positionCount = renderer.positionCount + 1;
        renderer.positionCount = 1;
    }

    public void RemovePoint()
    {
       
        LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer; renderer.positionCount = renderer.positionCount + 1;
        renderer.positionCount = renderer.positionCount- 1;
       // Debug.Log(renderer.positionCount);
    }

    public void SetPoints(int a)
    {

        LineRenderer renderer = gameObject.GetComponent(typeof(LineRenderer)) as LineRenderer; renderer.positionCount = renderer.positionCount + 1;
        renderer.positionCount = a;
        //Debug.Log(renderer.positionCount);
    }


    // Start is called before the first frame update
    void Start()
    {
        rayId = GetInstanceID();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
