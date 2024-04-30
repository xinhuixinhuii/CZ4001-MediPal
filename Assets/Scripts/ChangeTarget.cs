using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine(SetNaviTarget.navTargetObject);
    }

    // Update is called once per frame
    /*void Update()
    {
        Console.WriteLine(dropdown.value);
*//*        if (dropdown == null)
        {

        }*//*
    }*/
    public void TargetPosition(GameObject target)
    {
        Console.WriteLine("test");
        Console.Write(target.transform.position);
        SetNaviTarget.navTargetObject = target;
    }
}
