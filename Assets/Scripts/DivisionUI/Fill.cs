using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour
{
    public VerticalFill vertical;
    public HorizontalFill horizontal;

    public enum HorizontalFill
    {
        left,
        auto,
        right,
        fill
    }

    public enum VerticalFill
    {
        top,
        auto,
        bottom,
        fill
    }
}