using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameData gameData;
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    private bool triggered;

    void Start()
    {
        gameOverPanel.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
    }
    void Update()
    {
        if (!triggered)
            CheckGameOver();
    }

    void CheckGameOver()
    {
        if (gameData.selfIntegrity <= 0)
        {
            TriggerGameOver("你不再记得自己是谁，也不记得要去哪里。八音盒停下了，世界归于寂静。");
        }
        else if (gameData.currentCarHP <= 0)
        {
            TriggerGameOver("汽车彻底报废在了荒原上。你站在路边，看着地平线上那遥不可及的灯火。");
        }
    }

    void TriggerGameOver(string reason)
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = reason;
        Time.timeScale = 0f; // 暂停游戏
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        triggered = false;
        gameData.ResetData();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
