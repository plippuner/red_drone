using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class SaveAction : MonoBehaviour
{

    public string Action = "None";
    public float CurrentATime = 0;
    public Vector3 Pos;



    public SaveAction(string inAction, float inCurrentTime, Vector3 inPos)
    {
        CurrentATime = inCurrentTime;
        Action = inAction;
        Pos = inPos;

}

}
