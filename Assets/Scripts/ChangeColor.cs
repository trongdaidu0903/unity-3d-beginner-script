using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer rend; 

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeColors(); 
        }
    }

    void ChangeColors()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value, 1f);
        rend.material.color = randomColor;
    }
}
