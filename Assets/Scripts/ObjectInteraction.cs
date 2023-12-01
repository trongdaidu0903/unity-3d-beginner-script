using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public int Points = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Points: " + Points.ToString());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("ObjectB"))
                {
                    Destroy(hit.collider.gameObject);
                    Points++;
                    Debug.Log("Points: " + Points);
                }
            }
        }
    }
}
