using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite idle, hurt;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void HitFace()
    {
        spriteRenderer.sprite = hurt;
    }

    public void Init()
    {
        spriteRenderer.sprite = idle;
    }
}
