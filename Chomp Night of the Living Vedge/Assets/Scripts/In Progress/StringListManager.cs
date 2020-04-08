using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "List/StringListManager")]
public class StringListManager : ScriptableObject
{
    public List<StringListData> stringListDatas;
    public int currentListNum;

    private StringListData ReturnCurrentData()
    {
        return stringListDatas[currentListNum];
    }

    private void IncrementListNum()
    {
        if (currentListNum < stringListDatas.Count - 1)
        {
            currentListNum++;
        }
        else
        {
            currentListNum = 0;
        }
    }

    public void UseNextListOnEnd()
    {
        if (ReturnCurrentData().currentLineNumber == ReturnCurrentData().stringListObj.Count - 1 )
        {
            IncrementListNum();
        }
    }
}