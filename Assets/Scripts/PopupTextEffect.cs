using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupTextEffect : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float fadeDuration = 1f;
    private TextMeshPro tmp;
    private float timer;

    void Start()
    {
        tmp = GetComponent<TextMeshPro>();
        timer = fadeDuration;
    }

    void Update()
    {
        transform.position += Vector3.up * floatSpeed * Time.deltaTime;
        timer -= Time.deltaTime;
        float alpha = Mathf.Clamp01(timer / fadeDuration);
        tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, alpha);

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
