using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private bool isMoving = false;
    private Vector3 moveDirection = Vector3.zero;
    private float moveSpeed = 0f; 
    private int mssv = 20120449;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMoving = !isMoving;

            if (isMoving)
            {
                moveSpeed = 2f + (mssv % 10);
                moveDirection = GetRandomDirection();
            }
        }

        if (isMoving)
        {
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    Vector3 GetRandomDirection()
    {
        int randomAxis = Random.Range(0, 3);
        Vector3 direction = Vector3.zero;

        switch (randomAxis)
        {
            case 0:
                direction = Vector3.right;
                break;
            case 1:
                direction = Vector3.up;
                break;
            case 2:
                direction = Vector3.forward;
                break;
        }

        return direction;
    }
}
