﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GuardFOV))]
public class GuardFOVEditor : Editor
{
    private void OnSceneGUI()
    {
        //GuardFOV fov = (GuardFOV)target;
        //Handles.color = Color.blue;
        //Handles.DrawWireArc(fov.transform.position, Vector3.up, Vector3.forward, 360, fov.viewRadius);
        //Vector3 viewAngleA = fov.DirFromAngle(-fov.viewAngle / 2, false);
        //Vector3 viewAngleB = fov.DirFromAngle(+fov.viewAngle / 2, false);

        //Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleA * fov.viewRadius);
        //Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleB * fov.viewRadius);
    }
}
