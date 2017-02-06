﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Needed for button to show up in map generator
[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        DrawDefaultInspector();

        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }

}
