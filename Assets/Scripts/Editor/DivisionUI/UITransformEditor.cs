using DivisionUI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static Fill;

[CustomEditor(typeof(UITransform))]
public class UITransformEditor : Editor
{
    private UITransform transform;
    private Vector2 pos;
    private Vector2 size;
    private HorizontalFill horizontalFill;
    private VerticalFill verticalFill;

    void OnEnabled()
    {
        transform = (UITransform) target;
        pos = transform.position;
        size = transform.size;
        horizontalFill = transform.fill.horizontal;
        verticalFill = transform.fill.vertical;
    }

    public override void OnInspectorGUI()
    {
        pos = EditorGUILayout.Vector2Field("Position", pos);
        size = EditorGUILayout.Vector2Field("Size", size);

        GUILayout.Label("Fill");

        horizontalFill = (HorizontalFill)EditorGUILayout.EnumPopup("Horizontal", horizontalFill);
        verticalFill = (VerticalFill)EditorGUILayout.EnumPopup("Vertical", verticalFill);

        HandleFill();
    }

    private void HandleFill()
    {
        /*UITransform parent = transform.gameObject.GetComponent<UITransform>();
        if (parent == null)
            return;

        switch(horizontalFill)
        {
            case HorizontalFill.fill:
                transform.position.x = parent.position.x;
                transform.size.x = parent.size.x;
                EditorGUILayout.BeginToggleGroup("Position", false);
                break;
        }*/ 
    }
}
