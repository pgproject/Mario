using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorWindowStats : EditorWindow
{
    [MenuItem("Stats/PlayerStats")]

    static void Init()
    {
        EditorWindowStats windowStats = (EditorWindowStats) GetWindow(typeof(EditorWindowStats));
        windowStats.Show();
    }

    private void OnValidate()
    {
        GeneralStats.Instance.CreateInstance();
    }

    private void OnGUI()
    {
        GUILayout.Label("Player Stats");
        GeneralStats.Instance.PlayerStats.OnGui();
    }
}
