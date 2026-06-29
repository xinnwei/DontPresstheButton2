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
        gameData.currentArea++;
        areaNameText.text = areaNames[gameData.currentArea - 1];
        areaTransitionPanel.SetActive(true);
    }

    void OnContinue()
    {
        areaTransitionPanel.SetActive(false);
    }

    void TriggerEnding()
    {
        endingManager.TriggerEnding();
    }
}
