using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]private Image icon;
    public int index;
    public Item item;
    private Button button;
    [SerializeField] TextMeshProUGUI equipText;
    public Character player;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(RefreshUI);
        player = GameManager.instance.player;
        SetItem();
    }
    public void SetItem()
    {
        if (item != null)
        {
            icon.gameObject.SetActive(true);
            icon.sprite = item.itemData.icon;
        }
        else
        {
            icon.gameObject.SetActive(false);
        }
    }

    public void RefreshUI()
    {
        if (!equipText.gameObject.activeSelf)
        {
            equipText.gameObject.SetActive(true);
            player.Equip(item);
        }
        else
        {
            equipText.gameObject.SetActive(false);
            player.Unequip(item);
        }
    }
}
