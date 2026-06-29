using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class EndingManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject endingPanel;
    public TextMeshProUGUI endingTitleText;
    public TextMeshProUGUI endingDescText;

    void Start()
    {
        endingPanel.SetActive(false);
    }

    public void TriggerEnding()
    {
        string title = "";
        string desc = "";

        if (gameData.selfIntegrity >= 80 && gameData.currentCarHP >= 60)
        {
            title = "奇怪的吟游诗人";
            desc = "你带着完整的自己抵达了希望之城，母亲的八音盒还在轻轻转动。";
        }
        else if (gameData.musicBoxTurnCount == 0 && gameData.currentCarHP < 60)
        {
            title = "蹒跚的幸存者";
            desc = "你从未逆转八音盒，但代价是这辆破旧的车几乎散架。你还是到了。";
        }
        else if (gameData.selfIntegrity < 40)
        {
            title = "空壳的回响";
            desc = "八音盒已经转动太多次了。抵达希望之城的那一刻，你想不起自己是谁。";
        }
        else
        {
            title = "褪色的旅人";
            desc = "你到了，带着一些失去，带着一些保留。这就是旅途。";
        }

        endingTitleText.text = title;
        endingDescText.text = desc;
        endingPanel.SetActive(true);
    }
}
