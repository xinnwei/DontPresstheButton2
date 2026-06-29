using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    [Header("GameData")]
    public GameData gameData;

    [Header("UI文本")]
    public TextMeshProUGUI carHPText;
    public TextMeshProUGUI partsText;
    public TextMeshProUGUI willText;
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI musicBoxCountText;

    void Update()
    {
        RefreshHUD();
    }

    void RefreshHUD()
    {
        carHPText.text = $"汽车完整度：{gameData.currentCarHP}";
        partsText.text = $"零件：{gameData.parts}";
        willText.text = $"意志：{gameData.will}/{gameData.maxWill}";
        dayText.text = $"第{gameData.currentDay}天";
        musicBoxCountText.text = $"八音盒逆转：{gameData.musicBoxTurnCount}";
    }
}