using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("HUD References")]
    public TMP_Text healthText;
    public TMP_Text moneyText;
    public Slider xpSlider;
    public GameObject hudRoot;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleHUD();
        }
    }

    void ToggleHUD()
    {
        if (hudRoot != null)
        {
            hudRoot.SetActive(!hudRoot.activeSelf);
        }
    }

    public void UpdateHealth(int health)
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }
    }

    public void UpdateMoney(int money)
    {
        if (moneyText != null)
        {
            moneyText.text = $"Money: {money}";
        }
    }

    public void UpdateXP(float current, float max)
    {
        if (xpSlider != null)
        {
            xpSlider.maxValue = max;
            xpSlider.value = current;
        }
    }
}
