using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Drag Rotator Axis Info", menuName = "Drag Rotator Axis Info")]
public class DragRotatorAxisInfo: ScriptableObject
{
    public float m_ForceMultiplier;
    public float m_MinDegrees;
    public float m_MaxDegrees;
    public float m_RestSeconds;
}