using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject add;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.DrawRay(transform.position, Quaternion.Euler(0,45,0)*transform.forward*500 , Color.red);
    }
}
