using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Enemy Health Data")]
public class SecondFloatData : ScriptableObject
{
    [SerializeField] private float enemyHealth;

    public float EnemyHealth
    {
        get
        {
            return EnemyHealth;
        }
        set
        {
            this.EnemyHealth = EnemyHealth;
        }
    }
}
