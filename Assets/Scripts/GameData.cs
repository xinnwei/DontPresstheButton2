using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Game/GameData")]
public class GameData : ScriptableObject
{
    [Header("汽车")]
    public int maxCarHP = 100;
    public int currentCarHP = 100;

    [Header("资源")]
    public int parts = 10;      // 零件
    public int will = 10;       // 意志
    public int maxWill = 10;

    [Header("隐藏数值")]
    public int selfIntegrity = 100;   // 自我完整度
    public int maxSelfIntegrity = 100;

    [Header("进度")]
    public int currentDay = 1;
    public int currentArea = 1;       // 当前区域1-5
    public string todayLog = "";
    public int musicBoxTurnCount = 0; // 八音盒逆转次数
    public int maxDays = 5;

    public void TurnMusicBox(int selfCost)
    {
        musicBoxTurnCount++;
        selfIntegrity -= selfCost;
        selfIntegrity = Mathf.Clamp(selfIntegrity, 0, maxSelfIntegrity);
    }

    // 夜晚自动回复意志
    public void NightRecover()
    {
        will += 3;
        will = Mathf.Clamp(will, 0, maxWill);
        currentDay++;
    }

    // 修车
    public void RepairCar(int partsUsed)
    {
        if (parts >= partsUsed)
        {
            parts -= partsUsed;
            currentCarHP += partsUsed * 8; // 1零件=8HP
            currentCarHP = Mathf.Clamp(currentCarHP, 0, maxCarHP);
        }
    }

    public bool IsGameOver()
    {
        return currentCarHP <= 0 || selfIntegrity <= 0;
    }

    public void ResetData()
    {
        currentCarHP = maxCarHP;
        parts = 10;
        will = 10;
        selfIntegrity = maxSelfIntegrity;
        currentDay = 1;
        currentArea = 1;
        musicBoxTurnCount = 0;
        todayLog = "";
    }
}