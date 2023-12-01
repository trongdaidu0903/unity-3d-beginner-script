using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        float randomY = Random.Range(10f, 20f);
        transform.position = new Vector3(0f, randomY, 0f);
    }

    void Update()
    {
        BasicMovement();
    }

    private void BasicMovement()
    {
        if(Input.GetKey("a"))
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        else if (Input.GetKey("d"))
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        else if (Input.GetKey("w"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        else if (Input.GetKey("s"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
    }
}
