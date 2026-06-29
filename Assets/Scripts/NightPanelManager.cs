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

    [Header("文本")]
    public TextMeshProUGUI repairInfoText;
    public TextMeshProUGUI diaryText;

    int daysPerArea = 3;

    void Start()
    {
        gameData.ResetData();
        nightPanel.SetActive(false);
        repairPanel.SetActive(false);
        diaryPanel.SetActive(false);

        endDayButton.onClick.AddListener(OpenRepairPanel);
        triggerCrisisButton.onClick.AddListener(travelManager.StartTravel);
        repairButton.onClick.AddListener(OnRepair);
        skipRepairButton.onClick.AddListener(OnSkipRepair);
        endDiaryButton.onClick.AddListener(OnEndDiary);
    }

    void OpenRepairPanel()
    {
        repairInfoText.text = $"零件：{gameData.parts}  汽车完整度：{gameData.currentCarHP}/{gameData.maxCarHP}\n修车消耗3个零件，回复15点完整度。";
        nightPanel.SetActive(true);
        repairPanel.SetActive(true);
        diaryPanel.SetActive(false);
    }

    void OnRepair()
    {
        gameData.RepairCar(3);
        Debug.Log("修车：零件-3，汽车+15");
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
        nightPanel.SetActive(false);
        diaryPanel.SetActive(false);

        if (gameData.currentDay % daysPerArea == 0)
        {
            areaManager.TryAdvanceArea();
        }
    }
}