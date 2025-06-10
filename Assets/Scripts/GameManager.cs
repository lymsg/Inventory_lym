using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Character player;
    public Item item;
    public ItemData swordItemData;
    public ItemData hammerItemData;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character("Yeongmin", 0, 1000, 10, 10, 100, 10,new List<Item>());
        player.AddItem(swordItemData);
        player.AddItem(hammerItemData);
    }
}
