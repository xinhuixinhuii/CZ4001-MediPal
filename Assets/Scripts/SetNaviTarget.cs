using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNaviTarget : MonoBehaviour
{
    public static GameObject navTargetObject;

    private NavMeshPath path;
    private LineRenderer line;

    
    public Material line1;
    public Material line2;
    private float distanceThreshold = 1f;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    private void Update()
    {
        Console.WriteLine("no target");
        if(navTargetObject != null)
        {
            Console.WriteLine(navTargetObject.name);
            NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;


            // Calculate distance between current position and destination
            
        }

    }
}
