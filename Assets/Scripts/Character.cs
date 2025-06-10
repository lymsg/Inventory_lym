
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string ID { get; private set; }
    public int Level{ get; private set; }
    public int Gold{ get; private set; }

    public int Attack{get;private set;}
    
    public int Shield{get;private set;}
    public int Health{get;private set;}
    public int Critical{get;private set;}
    public List<Item> Inventory{get;private set;}
    public Character(string id, int level, int gold,int attack, int shield, int health, int critical, List<Item> inventory)
    {
        this.ID = id;
        this.Level = level;
        this.Gold = gold;
        this.Attack = attack;
        this.Shield = shield;
        this.Health = health;
        this.Critical = critical;
        this.Inventory = inventory;
    }

    public void AddItem(ItemData itemdata)
    {
        //this.Inventory.Add(item);
        Inventory.Add(new Item(itemdata));
    }

    public void Equip(Item item)
    {
        // Attack += item.attackValue;
        // Shield += item.shieldValue;
        // Health += item.healthValue;
        // Critical += item.criticalValue;
        Attack += item.itemData.attackValue;
        Shield += item.itemData.shieldValue;
        Health += item.itemData.healthValue;
        Critical += item.itemData.criticalValue;
    }

    public void Unequip(Item item)
    {
        // Attack -= item.AttackValue;
        // Shield -= item.ShieldValue;
        // Health -= item.HealthValue;
        // Critical -= item.CriticalValue;
        Attack -= item.itemData.attackValue;
        Shield -= item.itemData.shieldValue;
        Health -= item.itemData.healthValue;
        Critical -= item.itemData.criticalValue;
    }
}
