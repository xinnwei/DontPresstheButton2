using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TravelManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject travelPanel;
    public GameObject nightPanel;
    public TextMeshProUGUI dialogueText;
    public Button nextButton;
    public CollectionEventManager collectionEventManager;
    public UnityEngine.UI.Image backgroundImage;
    public Sprite[] areaBackgrounds;

    int currentLineIndex;
    int areaIndex;
    int totalLines;

    void Start()
    {
        travelPanel.SetActive(false);
        nextButton.onClick.AddListener(OnNextLine);
    }

    public void StartTravel()
    {
        currentLineIndex = 0;
        areaIndex = Mathf.Clamp(gameData.currentArea - 1, 0, 4);
        totalLines = GameDatabase.GetTravelLineCount(areaIndex);

        if (nightPanel != null)
            nightPanel.SetActive(false);

        if (areaBackgrounds.Length > areaIndex)
            backgroundImage.sprite = areaBackgrounds[areaIndex];

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
            int dayIndex = gameData.currentDay - 1; // 0-based for GameDatabase
            collectionEventManager.TriggerCollection(dayIndex);
        }
    }

    void OnNextLine()
    {
        currentLineIndex++;
        ShowLine();
    }
}
