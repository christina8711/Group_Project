using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 iniPos;
    // Start is called before the first frame update
    void Start()
    {
        iniPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(iniPos.x, Mathf.Sin(Time.time * freq) * amp * iniPos.y, 0);
    }
}
