using System;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private Inventory _inventory;
    
    private void Awake()
    {
        _inventory = Inventory.Instance;
    }


    public void AddItem(ScriptableObject item)
    {
        _inventory.InventoryStash.Add(item, _inventory.InventoryStash.Count+1);
    }

    public void RemoveItem(ScriptableObject item)
    {
        _inventory.InventoryStash.Remove(item);
    }

    public void DisplayItems()
    {
        foreach (var item in _inventory.InventoryStash)
        {
            Debug.Log(item.Key.name);           
        }
    }
}
