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

    void Start()
    {
        gameOverPanel.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
    }
    void Update()
    {
        CheckGameOver();
    }

    void CheckGameOver()
    {
        if (gameData.currentCarHP <= 0)
        {
            TriggerGameOver("迷失于静默——汽车完整度归零，旅途就此终结。");
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
        gameData.ResetData();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
