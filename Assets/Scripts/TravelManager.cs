using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TravelManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject travelPanel;
    public GameObject nightPanel;
    public GameObject collectionPanel;
    public GameObject dayCrisisPanel;
    public GameObject areaTransitionPanel;
    public TextMeshProUGUI dialogueText;
    public Button nextButton;
    public CollectionEventManager collectionEventManager;
    public Sprite[] areaBackgrounds;

    int currentLineIndex;
    int areaIndex;
    int totalLines;
    private Image bgImage;

    void Start()
    {
        travelPanel.SetActive(false);
        nextButton.onClick.AddListener(OnNextLine);
        var bg = travelPanel.transform.Find("Background");
        if (bg != null) bgImage = bg.GetComponent<Image>();
    }

    public void StartTravel()
    {
        currentLineIndex = 0;
        areaIndex = Mathf.Clamp(gameData.currentArea - 1, 0, 4);
        totalLines = GameDatabase.GetTravelLineCount(areaIndex);

        if (nightPanel != null) nightPanel.SetActive(false);
        if (collectionPanel != null) collectionPanel.SetActive(false);
        if (dayCrisisPanel != null) dayCrisisPanel.SetActive(false);
        if (areaTransitionPanel != null) areaTransitionPanel.SetActive(false);

        if (bgImage != null && areaBackgrounds.Length > areaIndex)
            bgImage.sprite = areaBackgrounds[areaIndex];

        travelPanel.SetActive(true);
        ShowLine();
    }

    void ShowLine()
    {
        if (currentLineIndex < totalLines)
        {
            dialogueText.text = GameDatabase.GetTravelDialogue(areaIndex, currentLineIndex);
        }
        else
        {
            travelPanel.SetActive(false);
            int dayIndex = gameData.currentDay - 1;
            collectionEventManager.TriggerCollection(dayIndex);
        }
    }

    void OnNextLine()
    {
        currentLineIndex++;
        ShowLine();
    }
}
