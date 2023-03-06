using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int tileCoordinates;

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
        }

        CalculateCoordinates();
    }

    void CalculateCoordinates()
    {
        
    }

    void DisplayCoordinates()
    {
        label.text = "--, --";
    }
}
