using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Cover : MonoBehaviour
{
    [SerializeField]
    float animationDelay;
    [SerializeField]
    Sprite[] cover;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        spriteRenderer.sprite=cover[0];
    }

    public IEnumerator CloseTheCover()
    {
        for(int i=1;i<cover.Length;i++)
        {
            spriteRenderer.sprite=cover[i];
            yield return new WaitForSeconds(animationDelay);
        }
    }
}
