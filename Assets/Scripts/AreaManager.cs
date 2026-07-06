using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AreaManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject areaTransitionPanel;
    public TextMeshProUGUI areaNameText;
    public Button continueButton;
    public EndingManager endingManager;

    // 💡 新增：引入危机管理器，用来在切章节时把它关掉，防止字撞车
    public DayCrisisManager dayCrisisManager;
    // 💡 新增：引入夜晚面板管理器，用来在点击 Continue 后重启新一天的 go forward 按钮
    public NightPanelManager nightPanelManager;

    string[] areaNames = {
        "第一章：告别故土",
        "第二章：静默之地",
        "第三章：机械坟场",
        "第四章：泪之沼泽",
        "第五章：希望之城外"
    };

    void Start()
    {
        areaTransitionPanel.SetActive(false);
        continueButton.onClick.AddListener(OnContinue);
    }

    public void TryAdvanceArea()
    {
        if (gameData.currentArea >= 5)
        {
            TriggerEnding();
            return;
        }

        // 🛠️ 修复1：当进入过渡面板时，强行把危机面板关掉，防止两个面板的字和按钮叠在一起撞车
        if (dayCrisisManager != null)
        {
            dayCrisisManager.dayCrisisPanel.SetActive(false);
        }

        gameData.currentArea++;
        areaNameText.text = areaNames[gameData.currentArea - 1];
        areaTransitionPanel.SetActive(true);
    }

    void OnContinue()
    {
        areaTransitionPanel.SetActive(false);

        // 🛠️ 修复2：点击 Continue 结束章节过渡后，必须主动让流程走下去！
        // 重新调用 nightPanelManager 的初始化，把新一天的 "go forward" 按钮老老实实召唤出来！
        if (nightPanelManager != null)
        {
            // 重新刷新天数UI并亮起 go forward 按钮
            nightPanelManager.OnReturnFromCrisis();
        }
    }

    void TriggerEnding()
    {
        endingManager.TriggerEnding();
    }
}