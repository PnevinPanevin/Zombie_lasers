using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recurcivecast : MonoBehaviour
{
    public GameObject RaySource;
    public float laserdmg = 0;

    List<Vector3> rayPoints = new List<Vector3>();

    void RecCast(Vector3 pos , Vector3 dir)
    {
        Debug.DrawRay(pos, dir * 200, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(pos,dir, out hit, 1000))
        {
            rayPoints.Add(hit.point);

            switch (hit.collider.tag)
            {
                case "mirror":


                    float inpAngle = Vector3.Angle(dir, hit.transform.right);
                    Vector3 castangle = Quaternion.Euler(0, 180 - inpAngle, 0) * -hit.transform.right;


                    RecCast(hit.point, castangle);
                    break;
                case "Zombie":


                    hit.collider.transform.GetComponent<BasicZombie>().Damage(laserdmg*Time.deltaTime);
                    break;
            }
            return;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rayPoints.Clear();
        rayPoints.Add(transform.position);
        RecCast(transform.position, transform.forward);
        transform.GetComponent<LineRenderer>().positionCount = rayPoints.Count;

        foreach(Vector3 pos in rayPoints)
        {
            transform.GetComponent<LineRenderer>().SetPosition(rayPoints.IndexOf(pos),pos);

        }

    }
}
