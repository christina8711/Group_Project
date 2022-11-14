using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;

    // Camera uses Cinemachine But this makes sure it follows target just incase
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}
