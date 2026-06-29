using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public string interactableName;
    public UnityEvent onInteract;
    private bool playerNearby = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            Debug.Log($"靠近：{interactableName}");
        }
    }



    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            Debug.Log($"离开：{interactableName}");
        }
    }

    void Update()
    {

       

        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log($"触发onInteract，对象={interactableName}");  // 加这行
            onInteract.Invoke();
        }

    }
}
