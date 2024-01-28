using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCake : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite idle, noLight;
    [SerializeField]
    float actDelay;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void LightOff()
    {
        spriteRenderer.sprite = noLight;
    }

    public void Init()
    {
        gameObject.SetActive(true);
        spriteRenderer.sprite = idle;
    }

}
