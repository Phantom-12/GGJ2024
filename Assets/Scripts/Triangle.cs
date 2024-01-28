using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite idle, eat;
    [SerializeField]
    float actDelay;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public IEnumerator Eat()
    {
        spriteRenderer.sprite = eat;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite = idle;
    }

    public void Init()
    {
        spriteRenderer.sprite = idle;
    }

}
