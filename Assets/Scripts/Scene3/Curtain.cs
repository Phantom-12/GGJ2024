using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite[] closeAnims;

    [SerializeField]
    float animDelay;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closeAnims[0];
    }

    public IEnumerator Close()
    {
        for (int i = 1; i < closeAnims.Length; i++)
        {
            spriteRenderer.sprite = closeAnims[i];
            yield return new WaitForSeconds(animDelay);
        }
    }
}
