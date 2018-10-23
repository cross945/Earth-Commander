using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensibilityX = 4f;
    private float sensibilityY = 1f;

    private const float Y_ANGLE_MIN = -70.0f;
    private const float Y_ANGLE_MAX = 15.0f;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        currentX += (Input.GetAxis("Mouse X") * sensibilityX);
        currentY += (Input.GetAxis("Mouse Y") * sensibilityY);

        Quaternion rotation = Quaternion.Euler(-currentY, currentX, 0f);
        transform.rotation = rotation;

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }
}
