using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

    //private const float Y_ANGLE_MIN = 0.0f;
    //private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    //private Camera cam;

    //private Vector3 _camerOffset;

    //[Range(0.01f, 1.0f)]
    //public float SmoothFactor = 0.5f;
    //public float RotationSpeed = 5.0f;

    private float distance = 5f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensibilityX = 4f;
    private float sensibilityY = 1f;


    private void Start()
    {
        camTransform = transform;
        //cam = Camera.main;
    }

    private void Update()
    {
        currentX += (Input.GetAxis("Mouse X") * sensibilityX);
        currentY += (Input.GetAxis("Mouse Y") * sensibilityY);

     // currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        //Vector3 dir = new Vector3(0, 0, -distance);
        //Quaternion rotation = Quaternion.Euler(-currentY, currentX, 0f);
        //transform.position = Vector3.Slerp(transform.position, dir, SmoothFactor);
        //camTransform.position = lookAt.position + rotation * dir;
        //camTransform.LookAt(lookAt.position);
    }
}
