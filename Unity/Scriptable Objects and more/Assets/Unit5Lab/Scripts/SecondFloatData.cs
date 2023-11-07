using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Second Float Data")]
public class SecondFloatData : ScriptableObject
{
    [SerializeField] private float value;

    public float Value
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
