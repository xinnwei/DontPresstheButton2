using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectionEventManager : MonoBehaviour
{
    public GameData gameData;
    public DayCrisisManager dayCrisisManager;

    [Header("面板")]
    public GameObject collectionPanel;
    public TextMeshProUGUI eventText;
    public Button confirmButton;

    private int pendingDayIndex;

    void Start()
    {
        collectionPanel.SetActive(false);
        confirmButton.onClick.AddListener(OnConfirm);
    }

    public void TriggerCollection(int dayIndex)
    {
        pendingDayIndex = dayIndex;
        var e = GameDatabase.GetCollectionEvent(dayIndex);
        eventText.text = e.description;
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
