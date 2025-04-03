using UnityEngine;
using TMPro;

public class CurrencyUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinDisplay, gemDisplay;

    void Update()
    {
        coinDisplay.text = GameManager.coinTotal.ToString();
        gemDisplay.text = GameManager.gemTotal.ToString();
    }
}
