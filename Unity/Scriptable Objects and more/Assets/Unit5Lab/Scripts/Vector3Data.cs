using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Vector3 Data", menuName = "Spawn Location Data")]
public class Vector3Data : ScriptableObject
{
    [SerializeField] private Vector3 spawnLocation;

    public Vector3 SpawnLocation
    {
        get
        {
            return SpawnLocation;
        }
        set
        {
            this.SpawnLocation = SpawnLocation;
        }
    }
}
