using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private IntData playerAmmo;

    private void Awake()
    {
        ResetAmmo();
    }

    private void ResetAmmo()
    {
        playerAmmo.value = 10;
    }

    //[SerializeField] public int value;
    public void AddAmmo(int ammoValue)
    {
        playerAmmo.value += ammoValue;
    }
}
