using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite idle, sword1, sword2, sword3;
    [SerializeField]
    float actDelay;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public IEnumerator Sword()
    {
        spriteRenderer.sprite = sword3;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite = sword2;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite = sword1;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite = idle;
    }

    public void Init()
    {
        spriteRenderer.sprite = idle;
    }

}
