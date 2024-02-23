using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foundation : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite foundation1, foundation2;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = foundation1;
    }

    public IEnumerator Hit()
    {
        spriteRenderer.sprite = foundation2;
        yield return 0;
    }
}
