using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI idText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI goldText;
    
    public GameObject buttons;
    public Button statusButton;
    public Button inventoryButton;

    private string id;
    private int level,gold,attack,shield,health,critical;
    private Character player;
    void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        player=GameManager.instance.player;
        SetCharacterInfo();
    }
    public void OpenMainMenu()
    {
        buttons.SetActive(true);
        UIManager.instance.MainMenuUI.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        buttons.SetActive(false);
        UIManager.instance.StatusUI.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        buttons.SetActive(false);
        UIManager.instance.InventoryUI.gameObject.SetActive(true);
    }

    public void SetCharacterInfo()
    {
        idText.text = player.ID;
        levelText.text = player.Level.ToString();
        goldText.text = string.Format("{0:N0}", player.Gold);
    }
}
