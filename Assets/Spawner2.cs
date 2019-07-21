using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner2 : MonoBehaviour
{
    public float mobDimension=1;
    public GameObject tgo;

    public List<GameObject> mobs = new List<GameObject>();
    public List<int> eachCount = new List<int>();
    public float timeInterval=1f;
    public int numberOfWaves=1;

    int waves = 0;

    bool inCollider = false;

    private void Start()
    {

        transform.GetComponent<BoxCollider>().size = new Vector3(mobDimension, mobDimension, mobDimension);
    }


    public void StartSpawn()
    {

        List<GameObject> allMobs = new List<GameObject>();
        int totalCount = 0;
        for (int i = 0; i < mobs.Count; i++)
        {
            totalCount = totalCount + eachCount[i];
        }




        waves = 0;
        InvokeRepeating("Spawn", 0, timeInterval);
    }

    public void Spawn()
    {
        //if (waves >= numberOfWaves-1)
        //{
        //    CancelInvoke();
        //}


        GameObject go = Instantiate(tgo);
        go.transform.position = transform.position;
        
        //foreach(Vector3 pos in posMatrix)
        //{
        //    GameObject go = Instantiate(tgo);
        //    go.transform.position = pos;
        //}
        //waves++;
    }
    private void OnTriggerExit(Collider other)
    {
        inCollider = false;
        Debug.Log("ex");
    }
    private void OnTriggerEnter(Collider other)
    {
        inCollider = true;
        Debug.Log("ent");
    }

  
    // Update is called once per frame
    void Update()
    {
        
    }
}
