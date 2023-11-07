using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    [SerializeField] private FloatData playerHealth;

    private void Awake()
    {
        ResetHealth();
    }

    private void ResetHealth()
    {
        playerHealth.value = 100f;
    }

   // [SerializeField] public float value;
    public void AddHealth(float healthValue)
    {
        playerHealth.value += healthValue;
    }
}
