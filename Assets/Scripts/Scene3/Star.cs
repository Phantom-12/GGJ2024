using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField]
    float animationDelay;
    [SerializeField]
    Sprite[] star;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        spriteRenderer.sprite=star[0];
    }

    public IEnumerator BreakTheStar()
    {
        for(int i=1;i<star.Length;i++)
        {
            spriteRenderer.sprite=star[i];
            yield return new WaitForSeconds(animationDelay);
        }
    }
}
