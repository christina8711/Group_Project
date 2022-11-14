using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 iniPos;
    // Bee's Start Position
    void Start()
    {
        iniPos = transform.position;
    }

    // While Game is playing Bee Moves up and down on Y-Axix
    void Update()
    {
        transform.position = new Vector3(iniPos.x, Mathf.Sin(Time.time * freq) * amp * iniPos.y, 0);
    }
}
