using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanInteraction : MonoBehaviour
{
    public GameObject caravanPanel;

    void Start()
    {
        caravanPanel.SetActive(false);
    }
    public void OpenCaravan()
    {
        caravanPanel.SetActive(true);
        Debug.Log("打开房车面板");
    }

    public void CloseCaravan()
    {
        caravanPanel.SetActive(false);
    }
}