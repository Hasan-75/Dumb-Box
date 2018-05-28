using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Vector3 offset;
    public Transform player;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = player.position + offset;
    }
}
