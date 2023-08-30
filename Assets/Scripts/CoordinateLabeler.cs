using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int tileCoordinates = new Vector2Int();

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateTileName();
        }
    }

    void DisplayCoordinates()
    {
        tileCoordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        tileCoordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        label.text = tileCoordinates.x.ToString() + ", " + tileCoordinates.y.ToString();
    }

    void UpdateTileName()
    {
        transform.parent.gameObject.name = "Tile: " + tileCoordinates.x.ToString() + ", " + tileCoordinates.y.ToString();
    }
}
