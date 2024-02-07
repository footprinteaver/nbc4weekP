using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Resource,
    Equipable,
    Consumable
}

public enum ConsumableType
{ 
    HP,
    MP,
}

public enum EquipableType
{
    Weapon,
    Armor,
    Accessory
}

[System.Serializable] 
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

public class ItemDataEquipable
{
    public EquipableType type;
}


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
 

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;

}
