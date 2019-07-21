using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ScoreInspector.addScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
