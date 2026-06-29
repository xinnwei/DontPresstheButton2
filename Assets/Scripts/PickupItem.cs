using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupItem : MonoBehaviour
{
    public GameData gameData;
    public int partsAmount = 1;
    public GameObject popupTextPrefab; // +1提示预制体

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameData.parts += partsAmount;
            Debug.Log($"拾取零件，当前parts={gameData.parts}");

            if (popupTextPrefab != null)
            {
                Instantiate(popupTextPrefab, transform.position, Quaternion.identity);
            }

            gameObject.SetActive(false); // 拾取后隐藏
        }
    }
}
