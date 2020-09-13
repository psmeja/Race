using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrack1 : MonoBehaviour
{

    public Transform[] navPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetNextNavPoint(ref int currentNavPointIndex)
    {
        currentNavPointIndex++;
        if (currentNavPointIndex == navPoints.Length)
        {
            currentNavPointIndex = 0;
        }
        return navPoints[currentNavPointIndex];
    }
}
