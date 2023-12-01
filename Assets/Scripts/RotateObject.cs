using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    private bool isRotating = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isRotating = !isRotating;

            if (!isRotating)
            {
                gameObject.transform.rotation = Quaternion.identity;
            }
        }

        if (isRotating)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            gameObject.transform.Rotate(Vector3.up, rotationAmount);
        }
    }
}
