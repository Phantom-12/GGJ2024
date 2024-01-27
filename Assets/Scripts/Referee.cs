using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Referee : MonoBehaviour
{
    Vector3 startPos;
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite idle,putDown,act1,act2,act3;
    [SerializeField]
    GameObject cloth;
    [SerializeField]
    float flyToBallDuration;
    [SerializeField]
    float toGroundSpeed;
    [SerializeField]
    float actDelay;

    void Awake()
    {
        startPos=transform.position;
        spriteRenderer=GetComponent<SpriteRenderer>();
        Init();
    }

    public IEnumerator FlyToBall(Vector3 ballPos)
    {
        spriteRenderer.sprite=putDown;
        Vector3 throwStartPos = transform.position;
        float startTime = Time.time;
        Vector3 flyVec = ballPos - throwStartPos;
        while (Time.time - startTime < flyToBallDuration)
        {
            transform.position = throwStartPos + (Time.time - startTime) / flyToBallDuration * flyVec;
            yield return 0;
        }
    }

    public IEnumerator BackToGround(Vector3 groundPos)
    {
        groundPos+=spriteRenderer.size.y/2*Vector3.up;
        spriteRenderer.sprite=idle;
        Vector3 startPos = transform.position;
        float startTime = Time.time;
        Vector3 flyVec = Vector3.down * (startPos.y - groundPos.y);
        float duration = (startPos.y - groundPos.y) / toGroundSpeed;
        while (Time.time - startTime < duration)
        {
            transform.position = startPos + (Time.time - startTime) / duration * flyVec;
            yield return 0;
        }
    }

    public IEnumerator Act()
    {
        spriteRenderer.sprite=idle;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite=act1;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite=act2;
        yield return new WaitForSeconds(actDelay);
        spriteRenderer.sprite=act3;
        cloth.SetActive(true);
    }

    public void Init()
    {
        transform.position=startPos;
        spriteRenderer.sprite=idle;
        cloth.SetActive(false);
    }
}
