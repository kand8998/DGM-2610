using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WorkSystemManager : ScriptableObject
{
    [Serializable]
    public struct WorkMatches
    {
        public NameID nameIdObj;
        public WorkSystem workSystemObj;
    }

   
}
