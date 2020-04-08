using JetBrains.Annotations;
using UnityEngine;

public class IDBehaviour : MonoBehaviour
{
    [CanBeNull] public NameID nameIDObj;

    public void ChangeId(NameID id)
    {
        nameIDObj = id;
    }
}
