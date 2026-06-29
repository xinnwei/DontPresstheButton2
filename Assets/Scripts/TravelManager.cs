using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TravelManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject travelPanel;
    public TextMeshProUGUI dialogueText;
    public Button nextButton;
    public DayCrisisManager dayCrisisManager;
    public NPCDialogueManager npcDialogueManager;
    public UnityEngine.UI.Image backgroundImage;
    public Sprite[] areaBackgrounds; // 五张背景图

    // 每个区域的出行文字，外层是区域，内层是句子
    string[][] areaDialogues = new string[][]
    {
        // 区域一：告别故土
        new string[] {
            "破旧的甲壳虫驶离了熟悉的街道。",
            "母亲的八音盒放在副驾驶座上，安静地待着。",
            "她说过，永远别逆转它。",
            "前方的路，没有人知道通向哪里。"
        },
        // 区域二：静默之地
        new string[] {
            "荒野一片寂静，连风声都消失了。",
            "收音机只有沙沙的杂音。",
            "不知道是信号太弱，还是已经没有人在广播了。"
        },
        // 区域三：机械坟场
        new string[] {
            "到处是锈迹斑斑的废弃机械。",
            "这里曾经是什么地方？",
            "也许能找到一些有用的零件。"
        },
        // 区域四：泪之沼泽
        new string[] {
            "地面开始变得泥泞，车轮陷进去又挣脱出来。",
            "空气里有一股潮湿的气息。",
            "希望之城还有多远？"
        },
        // 区域五：希望之城外
        new string[] {
            "远处的地平线上，隐约有建筑的轮廓。",
            "快到了。",
            "母亲说那里没有被影响，不知道是不是真的。"
        }
    };

    int currentLineIndex = 0;
    string[] currentDialogues;

    void Start()
    {
        travelPanel.SetActive(false);
        nextButton.onClick.AddListener(OnNextLine);
    }

    public void StartTravel()
    {
        currentLineIndex = 0;
        int areaIndex = Mathf.Clamp(gameData.currentArea - 1, 0, areaDialogues.Length - 1);
        currentDialogues = areaDialogues[areaIndex];
        travelPanel.SetActive(true);
        ShowLine();

        currentLineIndex = 0;

        currentDialogues = areaDialogues[areaIndex];
        // 切换背景
        if (areaBackgrounds.Length > areaIndex)
        {
            backgroundImage.sprite = areaBackgrounds[areaIndex];
        }
        travelPanel.SetActive(true);
        ShowLine();
    }

    void ShowLine()
    {
        if (currentLineIndex < currentDialogues.Length)
        {
            dialogueText.text = currentDialogues[currentLineIndex];
        }
        else
        {
            travelPanel.SetActive(false);
            dayCrisisManager.TriggerCrisis();
        }
    }

    void OnNextLine()
    {
        currentLineIndex++;
        ShowLine();
    }
}
