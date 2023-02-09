using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{   // Sets the camera position
    public GameObject plane;
    private Vector3 offset = new Vector3(40, 0, 10);

    // Update for camera position is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
