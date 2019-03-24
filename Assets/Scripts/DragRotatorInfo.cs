using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[CreateAssetMenu(fileName = "New Drag Rotator Info", menuName = "Drag Rotator Info")]
public class DragRotatorInfo: ScriptableObject
{
    public DragRotatorAxisInfo m_PitchInfo;
    public DragRotatorAxisInfo m_RollInfo;
}