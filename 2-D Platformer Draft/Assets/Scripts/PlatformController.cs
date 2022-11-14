using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Vector3 posA;
    public Vector3 PosB;
    public float speed = 1.0f;
    // Update is called once per frame
    // Lets you input posA vertices and PosB Vertices
    // Moves platform from posA to posB at a set speed
    // IF YOU ARE using this code on a tilemap platform make sure platform is placed in center of tile map position(0,0)
    void Update()
    {
        transform.position = Vector3.Lerp(posA, PosB, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
