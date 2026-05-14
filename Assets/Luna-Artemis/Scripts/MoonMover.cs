using UnityEngine;
using Sirenix.OdinInspector;

public class MoonMover : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 100f;

    [Header("Limits")]
    public float leftLimit = -300f;
    public float rightLimit = 300f;

    private RectTransform rectTransform;

    private int direction = 1;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        MoveMoon();
    }

    private void MoveMoon()
    {
        rectTransform.anchoredPosition += Vector2.right * direction * speed * Time.deltaTime;

        if (rectTransform.anchoredPosition.x >= rightLimit)
        {
            direction = -1;
        }

        if (rectTransform.anchoredPosition.x <= leftLimit)
        {
            direction = 1;
        }
    }
}