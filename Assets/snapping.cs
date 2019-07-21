using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class snapping : MonoBehaviour
{

    int x = 0;
    int z = 0;
    void Update()
    {
        x = Mathf.RoundToInt(transform.position.x);
        z = Mathf.RoundToInt(transform.position.z);
        if(transform.position.x!=x || transform.position.z != z)
        {
            transform.position =new Vector3(x, 0, z);
        }

    }
}
