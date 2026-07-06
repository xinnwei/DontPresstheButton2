using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectionEventManager : MonoBehaviour
{
    public GameData gameData;
    public DayCrisisManager dayCrisisManager;

    [Header("面板")]
    public GameObject collectionPanel;
    public GameObject travelPanel;
    public TextMeshProUGUI eventText;
    public Button confirmButton;

    [Header("背景")]
    public Sprite[] areaBackgrounds;

    private int pendingDayIndex;
    private Image bgImage;

    void Start()
    {
        collectionPanel.SetActive(false);
        confirmButton.onClick.AddListener(OnConfirm);
        bgImage = collectionPanel.GetComponent<Image>();
    }

    public void TriggerCollection(int dayIndex)
    {
        pendingDayIndex = dayIndex;
        var e = GameDatabase.GetCollectionEvent(dayIndex);
        eventText.text = e.description;
        if (travelPanel != null) travelPanel.SetActive(false);

        int areaIdx = Mathf.Clamp(dayIndex, 0, areaBackgrounds.Length - 1);
        if (bgImage != null && areaBackgrounds.Length > areaIdx)
            bgImage.sprite = areaBackgrounds[areaIdx];

        collectionPanel.SetActive(true);
    }

    void OnConfirm()
    {
        var e = GameDatabase.GetCollectionEvent(pendingDayIndex);
        gameData.parts += e.partsGained;
        Debug.Log($"收集事件: +{e.partsGained}零件, 当前零件={gameData.parts}");

        collectionPanel.SetActive(false);
        dayCrisisManager.TriggerCrisis(pendingDayIndex);
    }
}
