using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static Inventory _instance;

    public static Inventory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Inventory>();
                if (_instance == null)
                {
                    var singletonObject = new GameObject(nameof(Inventory));
                    _instance = singletonObject.AddComponent<Inventory>();
                }
            }

            return _instance;
        }
    }

    public Dictionary<ScriptableObject, int> InventoryStash;

}