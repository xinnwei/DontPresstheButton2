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
    public Sprite[] areaBackgrounds;

    public DayCrisisManager dayCrisisManager;
    public NightPanelManager nightPanelManager;
    private Image bgImage;

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
        if (continueButton == null)
            continueButton = areaTransitionPanel.GetComponentInChildren<Button>();
        if (continueButton != null)
            continueButton.onClick.AddListener(OnContinue);
        bgImage = areaTransitionPanel.GetComponent<Image>();
    }

    public void TryAdvanceArea()
    {
        if (gameData.currentArea >= 5)
        {
            TriggerEnding();
            return;
        }

        if (dayCrisisManager != null)
            dayCrisisManager.dayCrisisPanel.SetActive(false);

        gameData.currentArea++;
        int areaIdx = gameData.currentArea - 1;
        areaNameText.text = areaNames[areaIdx];

        if (bgImage != null && areaBackgrounds.Length > areaIdx)
            bgImage.sprite = areaBackgrounds[areaIdx];

        areaTransitionPanel.SetActive(true);
    }

    void OnContinue()
    {
        areaTransitionPanel.SetActive(false);
        if (nightPanelManager != null)
        {
            nightPanelManager.triggerCrisisButton.gameObject.SetActive(false);
            nightPanelManager.travelManager.StartTravel();
        }
    }

    void TriggerEnding()
    {
        endingManager.TriggerEnding();
    }
}
