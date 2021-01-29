using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBigCube : MonoBehaviour
{
    private Vector3 prevPressPos;
    private Vector2 mouseDelta;
    private float sens = 0.2f;
    public Transform axis; //Custom axis is set in inspector to align with orientation of camera.

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool isRotating;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    void Update()
    {
        Drag();
        ResetCube();
    }

    void Drag()
    {
        if (Input.GetMouseButtonDown(1))
        {
            prevPressPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }

        //While holding right click, the cube pans around the previous set axis.
        if (Input.GetMouseButton(1))
        {
            mouseDelta = Input.mousePosition - prevPressPos;
            mouseDelta *= sens;
            transform.RotateAround(axis.position, axis.right, mouseDelta.y);
            transform.RotateAround(axis.position, axis.up, -mouseDelta.x);
            prevPressPos = Input.mousePosition;
        }

        //Use mouse wheel to rotate around third axis.
        transform.RotateAround(axis.position, axis.forward, Input.mouseScrollDelta.y * 10f);
    }

    //Resets the position and orientation of the cube.
    void ResetCube()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(2))
        {
            isRotating = true;
        }
        if (isRotating)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, Time.deltaTime * 500f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, originalRotation, Time.deltaTime * 500f);
            if (transform.rotation == originalRotation && transform.position == originalPosition)
            {
                isRotating = false;
            }
        }
    }

}
