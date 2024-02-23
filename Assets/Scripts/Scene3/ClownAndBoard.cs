using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownAndBoard : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite[] fallAnims;

    [SerializeField]
    float animDelay;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = fallAnims[0];
    }

    public IEnumerator Fall()
    {
            Debug.Log(fallAnims.Length);
        for (int i = 1; i < fallAnims.Length; i++)
        {
            Debug.Log(i);
            spriteRenderer.sprite = fallAnims[i];
            yield return new WaitForSeconds(animDelay);
        }
    }
}
