using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenuManager : MonoBehaviour
{
    public Button startButton;
    public TextMeshProUGUI titleText;

    void Start()
    {
        titleText.text = "Don't touch the button";
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("narrative");
    }
}
