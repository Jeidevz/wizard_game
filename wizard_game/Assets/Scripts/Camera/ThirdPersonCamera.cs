﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonCamera : MonoBehaviour
{
    public bool lockCursor;
    public Transform target;
    public float verticalRotateSpeed = 100f;
    public float horizontalRotateSpeed = 100f;
    public float distanceFromTarget = 2f;
    public float rightFromTarget = 0f;
    public float upFromtTarget = 0f;
    public float scrollSpeed = 1000f;
    public int rotateVMin = -60, rotateVMax = 80;
    public float rotationSmoothTime = 0.1f;

    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;
    float rotateV, rotateH;

    void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void LateUpdate()
    {
        distanceFromTarget -= Input.GetAxisRaw("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime;

        rotateH += Input.GetAxisRaw("Mouse X") * horizontalRotateSpeed * Time.deltaTime;
        rotateV -= Input.GetAxisRaw("Mouse Y") * verticalRotateSpeed * Time.deltaTime;
        rotateV = Mathf.Clamp(rotateV, rotateVMin, rotateVMax);


        Vector3 targetRotation = new Vector3(rotateV, rotateH);

        currentRotation = Vector3.SmoothDamp(currentRotation, targetRotation, ref rotationSmoothVelocity, rotationSmoothTime);

        transform.eulerAngles = currentRotation;
        transform.position = target.position - transform.forward * distanceFromTarget + transform.up * upFromtTarget + transform.right * rightFromTarget;


    }
}
