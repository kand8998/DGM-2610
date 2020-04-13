using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "List/Vector3ListData")]
public class Vector3ListData : ScriptableObject
{
    public List<Vector3Data> Vector3ListObj;
    public int currentLineNumber;

    public Vector3Data ReturnCurrentLine()
    {
        return Vector3ListObj[currentLineNumber];
    }

    public void ResetToZero()
    {
        currentLineNumber = 0;
    }

    public void IncrementLineNumber()
    {
        if (currentLineNumber < Vector3ListObj.Count)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
    }
}
