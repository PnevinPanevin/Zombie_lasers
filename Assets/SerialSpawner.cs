using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SerialSpawner : MonoBehaviour
{
    public List<GameObject> mobs = new List<GameObject>();
    public List<int> numberEach = new List<int>();
    public float rushDelay;
    public GameObject destination;
    int collidercount=0;
    bool startSpawn = false;

    List<GameObject> allMobs = new List<GameObject>();


    public void Spawn()
    {
        ScoreInspector.resetScore();
        foreach(GameObject mob in mobs)
        {
            for(int i=0; i<numberEach[mobs.IndexOf(mob)];  i++)
            {
                allMobs.Add(mob);
            }
        }
        Debug.Log("all_mobs count__"+allMobs.Count);

        foreach (GameObject mob in allMobs)
        {
            Debug.Log(transform.position);
                GameObject go = Instantiate(mob);
                go.transform.position = transform.position;
            go.transform.GetComponent<NavMeshAgent>().enabled = true;
                go.transform.GetComponent<BasicZombie>().Destination(destination.transform.position);
            

        }
        allMobs.Clear();
        //startSpawn = true;
    }

    bool CheckCollider()
    {
        if (collidercount != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (startSpawn)
        //{
        //    if (CheckCollider()&&allMobs.Count!=0)
        //    {
        //        GameObject go = Instantiate(allMobs.Dequeue());
        //        go.transform.position = transform.position;
        //        go.transform.GetComponent<BasicZombie>().Destination(destination.transform.position);
        //    }
        //    if (allMobs.Count == 0)
        //    {
        //        startSpawn = false;
        //    }
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        ++collidercount;
        
    }
    private void OnTriggerExit(Collider other)
    {
        --collidercount;
    }
}
