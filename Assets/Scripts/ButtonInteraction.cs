using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteraction : MonoBehaviour
{
    public GameData gameData;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnMusicBoxTurned);
    }

    void OnMusicBoxTurned()
    {
        gameData.TurnMusicBox();
        Debug.Log($"八音盒逆转次数：{gameData.musicBoxTurnCount} | 自我完整度：{gameData.selfIntegrity}");
    }
}
