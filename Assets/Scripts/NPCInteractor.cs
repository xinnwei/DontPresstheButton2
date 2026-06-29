using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractor : MonoBehaviour
{
    [Header("NPC Info")]
    [SerializeField] private string npcName = "村民";
    [TextArea(2, 5)]
    [SerializeField] private string[] lines;

    [Header("Settings")]
    [SerializeField] private float triggerRadius = 2f;
    [SerializeField] private KeyCode interactKey = KeyCode.E;

    private Transform player;
    private bool playerInRange;

    void Start()
    {
        var p = GameObject.FindGameObjectWithTag("Player");
        if (p != null) player = p.transform;
    }

    void Update()
    {
        if (player == null) return;

        playerInRange = Vector3.Distance(transform.position, player.position) <= triggerRadius;

        if (playerInRange) Debug.Log("在范围内，按E键：" + Input.GetKeyDown(interactKey));



        if (playerInRange && Input.GetKeyDown(interactKey))
        {
            var mgr = NPCDialogueManager.Instance;
            if (mgr == null) return;

            // 对话框已开着就推进，没开就开启
            if (mgr.npcPanel.activeSelf)
                mgr.OnNext();
            else
                mgr.StartDialogue(npcName, lines);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, triggerRadius);
    }
}
