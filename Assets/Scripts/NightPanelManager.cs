using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NightPanelManager : MonoBehaviour
{
    public GameData gameData;
    public AreaManager areaManager;
    public DayCrisisManager dayCrisisManager;
    public TravelManager travelManager;

    [Header("面板")]
    public GameObject nightPanel;
    public GameObject repairPanel;
    public GameObject diaryPanel;

    [Header("按钮")]
    public Button endDayButton;
    public Button triggerCrisisButton;
    public Button repairButton;
    public Button skipRepairButton;
    public Button endDiaryButton;
    public Button repairPlusButton;
    public Button repairMinusButton;

    [Header("文本")]
    public TextMeshProUGUI repairInfoText;
    public TextMeshProUGUI diaryText;

    int partsToRepair;

    void Start()
    {
        gameData.ResetData();
        repairPanel.SetActive(false);
        diaryPanel.SetActive(false);

        endDayButton.onClick.AddListener(OpenRepairPanel);
        triggerCrisisButton.onClick.AddListener(OnGoForward);
        repairButton.onClick.AddListener(OnRepair);
        skipRepairButton.onClick.AddListener(OnSkipRepair);
        endDiaryButton.onClick.AddListener(OnEndDiary);
        repairPlusButton.onClick.AddListener(OnRepairPlus);
        repairMinusButton.onClick.AddListener(OnRepairMinus);

        ShowGoForward();
    }

    void OnGoForward()
    {
        triggerCrisisButton.gameObject.SetActive(false);
        travelManager.StartTravel();
    }

    public void OnReturnFromCrisis()
    {
        nightPanel.SetActive(true);
        ShowEndDay();
    }

    void ShowGoForward()
    {
        triggerCrisisButton.gameObject.SetActive(true);
        endDayButton.gameObject.SetActive(false);
    }

    void ShowEndDay()
    {
        triggerCrisisButton.gameObject.SetActive(false);
        endDayButton.gameObject.SetActive(true);
    }

    void OpenRepairPanel()
    {
        // 默认选择修复至满血所需零件数
        int hpNeeded = gameData.maxCarHP - gameData.currentCarHP;
        int partsNeeded = Mathf.CeilToInt(hpNeeded / 8f);
        partsToRepair = Mathf.Clamp(partsNeeded, 0, gameData.parts);
        UpdateRepairText();
        nightPanel.SetActive(true);
        repairPanel.SetActive(true);
        diaryPanel.SetActive(false);
    }

    void OnRepairPlus()
    {
        int maxParts = Mathf.Min(gameData.parts, Mathf.CeilToInt((gameData.maxCarHP - gameData.currentCarHP) / 8f));
        if (partsToRepair < maxParts)
        {
            partsToRepair++;
            UpdateRepairText();
        }
    }

    void OnRepairMinus()
    {
        if (partsToRepair > 0)
        {
            partsToRepair--;
            UpdateRepairText();
        }
    }

    void UpdateRepairText()
    {
        int hpRecover = partsToRepair * 8;
        int newHP = Mathf.Min(gameData.currentCarHP + hpRecover, gameData.maxCarHP);
        repairInfoText.text = $"零件：{gameData.parts}  汽车完整度：{gameData.currentCarHP}/{gameData.maxCarHP}\n消耗 {partsToRepair} 个零件，回复 {hpRecover} 点 → {newHP}/{gameData.maxCarHP}";
    }

    void OnRepair()
    {
        if (partsToRepair > 0)
        {
            int hpBefore = gameData.currentCarHP;
            gameData.RepairCar(partsToRepair);
            Debug.Log($"修车：零件-{partsToRepair}，汽车+{gameData.currentCarHP - hpBefore}");
        }
        OpenDiaryPanel();
    }

    void OnSkipRepair()
    {
        OpenDiaryPanel();
    }

    void OpenDiaryPanel()
    {
        repairPanel.SetActive(false);
        diaryText.text = string.IsNullOrEmpty(gameData.todayLog)
            ? "今天没有发生什么特别的事。"
            : gameData.todayLog;
        diaryPanel.SetActive(true);
    }

    void OnEndDiary()
    {
        gameData.NightRecover();
        gameData.todayLog = "";
        diaryPanel.SetActive(false);

        // NightRecover 后 currentDay 已+1，奇数=刚完成区域内第2天
        if (gameData.currentDay > 10)
        {
            areaManager.endingManager.TriggerEnding();
            return;
        }
        if (gameData.currentDay == 4 || gameData.currentDay == 7 || gameData.currentDay == 10)
        {
            areaManager.TryAdvanceArea();
        }

        ShowGoForward();
    }
}