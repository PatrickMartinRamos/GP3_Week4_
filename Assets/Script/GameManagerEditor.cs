using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static gameManager;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(gameManager)), CanEditMultipleObjects]
public class GameManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        gameManager myScript = (gameManager)target;
        if (GUILayout.Button("Reset"))
        {
            myScript.ResetValues();
        }
        if (GUILayout.Button("AddPowerUpConcentration"))
        {
            myScript.DamagePowerUp_Concentration();
        }
        if (GUILayout.Button("AddEXP"))
        {
            myScript.AddExp(myScript.expToAdd);
        }
    }
}

