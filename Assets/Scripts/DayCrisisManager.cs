using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DayCrisisManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject dayCrisisPanel;
    public NightPanelManager nightPanelManager;

    [Header("按钮")]
    public Button struggle1Button;
    public Button struggle2Button;
    public Button musicBoxButton;

    [Header("按钮文本")]
    public TextMeshProUGUI struggle1Label;
    public TextMeshProUGUI struggle2Label;

    [Header("文本")]
    public TextMeshProUGUI crisisText;

    private CrisisData currentCrisis;
    private int currentDayIndex;

    void Start()
    {
        dayCrisisPanel.SetActive(false);
        struggle1Button.onClick.AddListener(OnStruggle1);
        struggle2Button.onClick.AddListener(OnStruggle2);
        musicBoxButton.onClick.AddListener(OnMusicBox);
    }

    public void TriggerCrisis(int dayIndex)
    {
        currentDayIndex = dayIndex;
        currentCrisis = GameDatabase.GetCrisis(dayIndex);

        crisisText.text = currentCrisis.description;
        struggle1Label.text = currentCrisis.optionA.label;
        struggle2Label.text = currentCrisis.optionB.label;

        // 检查按钮是否可选（资源不足则灰色）
        struggle1Button.interactable = gameData.will >= currentCrisis.optionA.willCost &&
                                        gameData.parts >= currentCrisis.optionA.partsCost;
        struggle2Button.interactable = gameData.will >= currentCrisis.optionB.willCost &&
                                        gameData.parts >= currentCrisis.optionB.partsCost;

        dayCrisisPanel.SetActive(true);
    }

    void OnStruggle1()
    {
        ApplyOption(currentCrisis.optionA);
    }

    void OnStruggle2()
    {
        ApplyOption(currentCrisis.optionB);
    }

    void ApplyOption(CrisisOption opt)
    {
        gameData.will -= opt.willCost;
        gameData.parts -= opt.partsCost;
        gameData.currentCarHP -= opt.carHPCost;
        gameData.currentCarHP = Mathf.Clamp(gameData.currentCarHP, 0, gameData.maxCarHP);
        gameData.todayLog = opt.log;
        Debug.Log($"[{currentCrisis.label}] {opt.label}: 意志-{opt.willCost}, 零件-{opt.partsCost}, 汽车-{opt.carHPCost}");
        CloseCrisis();
    }

    void OnMusicBox()
    {
        gameData.TurnMusicBox(currentCrisis.reversalSelfCost);
        gameData.todayLog = "逆转了八音盒，危机消散了，但有什么东西再也回不来了。";
        Debug.Log($"[{currentCrisis.label}] 逆转八音盒: 自我-{currentCrisis.reversalSelfCost}, 当前自我完整度={gameData.selfIntegrity}");
        CloseCrisis();
    }

    void CloseCrisis()
    {
        dayCrisisPanel.SetActive(false);
        if (nightPanelManager != null)
            nightPanelManager.OnReturnFromCrisis();
    }
}
