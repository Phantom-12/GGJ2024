using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite apple1, apple2;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = apple1;
    }

    public IEnumerator Hit()
    {
        spriteRenderer.sprite = apple2;
        yield return 0;
    }
}
