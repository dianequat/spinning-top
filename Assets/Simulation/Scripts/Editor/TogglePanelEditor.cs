// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TogglePanel)), CanEditMultipleObjects]
public class TogglePanelEditor : Editor
{
    private TogglePanel component;

    private void OnEnable()
    {
        component = (TogglePanel)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUI.changed)
        {
            component.SetDivider();
        }
    }
}
