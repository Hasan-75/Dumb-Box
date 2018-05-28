using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMove : MonoBehaviour {

    // Use this for initialization
 
    public Grid g;
    public Rigidbody[] rbs;
    private void Start()
    {
        rbs = g.GetComponentsInChildren<Rigidbody>();

    }
    // Update is called once per frame
    void FixedUpdate () {
        Invoke("rotateF", 3);
    }

    private void rotateF()
    {
        foreach (Rigidbody r in rbs)
        {
            //Debug.Log(r);
            r.AddTorque(0, 500, 0);
        }
    }
}
