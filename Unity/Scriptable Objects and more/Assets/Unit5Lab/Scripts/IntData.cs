using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Weapon Damage Data")]
public class IntData : ScriptableObject
{
    [SerializeField] private int weaponDamage;

    public int WeaponDamage
    {
        get
        {
            return WeaponDamage;
        }
        set
        {
            this.WeaponDamage = WeaponDamage;
        }
    }
}

