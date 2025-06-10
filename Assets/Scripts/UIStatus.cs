
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attackValueText;
    public TextMeshProUGUI shieldValueText;
    public TextMeshProUGUI healthValueText;
    public TextMeshProUGUI criticalValueText;
    [SerializeField]private Button backButton;

    public Character player;
    private void Start()
    {
        //player = GameManager.instance.player;
        backButton.onClick.AddListener(OnClickBack);
    }

    void OnEnable()
    {
        player = GameManager.instance.player;
        StatusSetInfo();
    }
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
        UIManager.instance.MainMenuUI.OpenMainMenu();
    }

    public void StatusSetInfo()
    {
        attackValueText.text = player.Attack.ToString();
        shieldValueText.text = player.Shield.ToString();
        healthValueText.text = player.Health.ToString();
        criticalValueText.text = player.Critical.ToString();
    }
}
