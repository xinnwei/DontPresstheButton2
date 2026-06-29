using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DayCrisisManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject dayCrisisPanel;

    [Header("按钮")]
    public Button struggle1Button;
    public Button struggle2Button;
    public Button musicBoxButton;

    [Header("文本")]
    public TextMeshProUGUI crisisText;

    string[] crisisDescriptions = {
        "前方道路被巨石封堵，绕路会消耗大量时间和零件。",
        "遇到一群饥肠辘辘的流浪者，他们盯上了你的车。",
        "引擎突然过热，继续行驶可能造成严重损坏。"
    };

    void Start()
    {
        dayCrisisPanel.SetActive(false);
        struggle1Button.onClick.AddListener(OnStruggle1);
        struggle2Button.onClick.AddListener(OnStruggle2);
        musicBoxButton.onClick.AddListener(OnMusicBox);
    }

    public void TriggerCrisis()
    {
        int index = Random.Range(0, crisisDescriptions.Length);
        crisisText.text = crisisDescriptions[index];
        dayCrisisPanel.SetActive(true);
    }

    void OnStruggle1()
    {
        if (gameData.will >= 3 && gameData.parts >= 2)
        {
            gameData.will -= 3;
            gameData.parts -= 2;
            gameData.currentCarHP -= 10;
            gameData.todayLog = "选择了挣扎求生，消耗了意志和零件，车受了点损伤。";
            Debug.Log("挣扎求生1：意志-3，零件-2，汽车-10");
        }
        else
        {
            Debug.Log("资源不足");
            return;
        }
        CloseCrisis();
    }

    void OnStruggle2()
    {
        if (gameData.will >= 5)
        {
            gameData.will -= 5;
            gameData.currentCarHP -= 5;
            gameData.todayLog = "咬牙撑过去了，意志消耗殆尽，车也磕磕碰碰。";
            Debug.Log("挣扎求生2：意志-5，汽车-5");
        }
        else
        {
            Debug.Log("意志不足");
            return;
        }
        CloseCrisis();
    }

    void OnMusicBox()
    {
        gameData.TurnMusicBox();
        gameData.todayLog = "逆转了八音盒，危机消散了，但有什么东西再也回不来了。";
        Debug.Log($"逆转八音盒：自我完整度：{gameData.selfIntegrity}");
        CloseCrisis();
    }

    void CloseCrisis()
    {
        dayCrisisPanel.SetActive(false);
    }
}