using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[ExecuteInEditMode]
public class Spawner : MonoBehaviour
{
    public float mobDimension=1;
    public GameObject tgo;

    public List<GameObject> mobs = new List<GameObject>();
    public List<int> eachCount = new List<int>();
    public float timeInterval=1f;
    public int numberOfWaves=1;

    int waves = 0;

    List<Vector3> posMatrix=new List<Vector3>();
    // Start is called before the first frame update


    public List<Vector3> GeneratePOsMatrix(Vector3 spawnerPos)
    {
        List<Vector3> matrix = new List<Vector3>();
        int totalCount=0;
        for(int i=0; i<mobs.Count; i++)
        {
            totalCount = totalCount + eachCount[i];
        }


        double f = Math.Sqrt(totalCount);
        f = Math.Truncate(f) + 1;
        int side = Convert.ToInt32(f) ;
        Debug.Log(side);

        float z = 0;
        float x = 0;
        for(int i = 0; i < totalCount;)
        {
            
            for(int k=0; k<side; k++)
            {
                Vector3 tempVector = new Vector3(spawnerPos.x + x, 0, spawnerPos.z + z);
                x=x+mobDimension;

                matrix.Add(tempVector);
                i++;
                if (i >= totalCount)
                {
                    break;
                }
            }
            x = 0;
            z=z+mobDimension;
        }

        return matrix;
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
        if (waves >= numberOfWaves-1)
        {
            CancelInvoke();
        }
        
        

        posMatrix = GeneratePOsMatrix(transform.position);
        foreach(Vector3 pos in posMatrix)
        {
            GameObject go = Instantiate(tgo);
            go.transform.position = pos;
        }
        waves++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
