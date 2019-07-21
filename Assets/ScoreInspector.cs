using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreInspector", menuName = "ScoreInspector", order = 1)]
public class ScoreInspector : ScriptableObject
{
    static int score = 0;

    public static void addScore()
    {
        score = score+1;
        Debug.Log(score);
    }

    public static void resetScore()
    {
        score = 0;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
