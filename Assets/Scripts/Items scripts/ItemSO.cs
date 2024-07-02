using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Consumable,
    Miscellaneous,
    Default
}

// ReSharper disable once InconsistentNaming
public abstract class ItemSO : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    
}