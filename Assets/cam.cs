using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
        transform.LookAt(playerTransform);
    }
}
