using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item
{
    // public string ItemName{get;private set;}
    // public int AttackValue{get;private set;}
    // public int ShieldValue{get;private set;}
    // public int HealthValue{get;private set;}
    // public int CriticalValue{get;private set;}
    // public Sprite Icon{get;private set;}
    //
    // public Item(string itemName, int attackValue, int shieldValue, int healthValue, int criticalValue,Sprite icon)
    // {
    //     this.ItemName = itemName;
    //     this.AttackValue = attackValue;
    //     this.ShieldValue = shieldValue;
    //     this.HealthValue = healthValue;
    //     this.CriticalValue = criticalValue;
    //     this.Icon = icon;
    // }
    public ItemData itemData;

    public Item(ItemData itemData)
    {
        this.itemData = itemData;
    }
}
