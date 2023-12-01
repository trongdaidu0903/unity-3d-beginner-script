using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeightAndRotate : MonoBehaviour
{
    public float heightChangeAmount = 2.0f; 
    public float rotationSpeed = 50.0f; 
    private bool isRotating = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ChangeHeight(); 

            isRotating = !isRotating; 

            if (!isRotating)
            {
                StopRotation();
            }
        }

        if (isRotating)
        {
            RotateObjects(); 
        }
    }

    void ChangeHeight()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += heightChangeAmount;
        transform.position = newPosition;
    }

    void StopRotation()
    {
        transform.rotation = Quaternion.identity;
    }

    void RotateObjects()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
