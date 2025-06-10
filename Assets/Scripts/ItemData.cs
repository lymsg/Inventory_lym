using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int attackValue;
    public int shieldValue;
    public int healthValue;
    public int criticalValue;
    public Sprite icon;
}
