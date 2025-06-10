
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public TextMeshProUGUI curSlotAmount;
    [SerializeField]private Button backButton;
    public UISlot slots;
    private List<UISlot> slotList = new List<UISlot>();
    public Transform slotsParent;
    
    private Character player;
    private void Start()
    {
        player = GameManager.instance.player;
        backButton.onClick.AddListener(OnClickBack);
        InitInventoryUI();
    }
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
        UIManager.instance.MainMenuUI.OpenMainMenu();
    }

    void InitInventoryUI()
    {
        int slotCount = 11;
        curSlotAmount.text = slotCount.ToString();
        
        int itemCount = player.Inventory.Count;
        for (int i = 0; i < slotCount; i++)
        {
            UISlot slot = Instantiate(slots, slotsParent);
            slotList.Add(slot);
            slotList[i].index = i;
            if (i <= itemCount - 1)
            {
                slotList[i].item = player.Inventory[i];
            }
        }
    }
    
}
