using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "List/StringListData")]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;
    public int currentLineNumber;

    public string ReturnCurrentLine()
    {
        return stringListObj[currentLineNumber];
    }

    public void ResetToZero()
    {
        currentLineNumber = 0;
    }

    public void IncrementLineNumber()
    {
        if (currentLineNumber < stringListObj.Count)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
    }
}