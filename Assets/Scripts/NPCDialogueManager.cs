using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NPCDialogueManager : MonoBehaviour
{
    public static NPCDialogueManager Instance { get; private set; }

    public GameObject npcPanel;
    public Image npcImage;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI npcDialogueText;
    public Button npcNextButton;

    System.Action onDialogueEnd;

    string[] currentLines;
    string currentName;
    int currentIndex;

    void Awake()
    {
        Instance = this;
        npcPanel.SetActive(false);
    }

    void Start()
    {
        npcNextButton.onClick.AddListener(OnNext);
    }

    public void StartDialogue(string npcName, string[] lines, System.Action onEnd = null)
    {
        currentName = npcName;
        currentLines = lines;
        currentIndex = 0;
        onDialogueEnd = onEnd;

        npcNameText.text = currentName;
        npcPanel.SetActive(true);
        ShowLine();
    }

    void ShowLine()
    {
        if (currentIndex < currentLines.Length)
        {
            npcDialogueText.text = currentLines[currentIndex];
        }
        else
        {
            npcPanel.SetActive(false);
            onDialogueEnd?.Invoke();
        }
    }

    public void OnNext()
    {
        currentIndex++;
        ShowLine();
    }

    public bool IsOpen() => npcPanel.activeSelf;
}
