
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // [SerializeField] private GameObject mainMenuUi;
    // [SerializeField] private GameObject statusUi;
    // [SerializeField] private GameObject inventoryUi;
    [SerializeField] private UIMainMenu mainMenuUi;
    [SerializeField] private UIStatus statusUi;
    [SerializeField] private UIInventory inventoryUi;
    
    public UIMainMenu MainMenuUI => mainMenuUi;
    public UIStatus StatusUI => statusUi;
    public UIInventory InventoryUI => inventoryUi;
    
    public static UIManager instance;

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
}
