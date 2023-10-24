using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New String Data", menuName = "Item Name Data")]
public class StringData : ScriptableObject
{
    [SerializeField] private string itemName;

    public float ItemName
    {
        get
        {
            return ItemName;
        }
        set
        {
            this.itemName = ItemName.ToString();
        }
    }
}
