using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouseOver : MonoBehaviour
{
    private Color originalColor; 
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>(); 
        originalColor = rend.material.color; 
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }

    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }
}
