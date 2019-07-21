using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class snappingLaser : MonoBehaviour
{

    int x = 0;
    int z = 0;
    void Update()
    {
        transform.GetComponent<LineRenderer>().SetPosition(0,transform.position);

    }
}
