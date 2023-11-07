using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Vector3 Data", menuName = "Vector 3 Data")]
public class Vector3Data : ScriptableObject
{
    [SerializeField] private Vector3 value;

    public Vector3 Value
    {
        get
        {
            return Value;
        }
        set
        {
            this.Value = Value;
        }
    }
}
