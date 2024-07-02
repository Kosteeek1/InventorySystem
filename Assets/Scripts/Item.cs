using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public ItemTypes.ItemType itemType;
    public new string name;
    public Sprite artWork;
    public float weight;
}