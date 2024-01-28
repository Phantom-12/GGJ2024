using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cake : MonoBehaviour
{
    bool isThrowing;
    Vector3 startPos;

    [SerializeField]
    float followScaling;
    [SerializeField]
    float flyDuration;

    public ParticleSystem hitEffect;

    void Awake()
    {
        isThrowing = false;
        startPos = transform.position;
    }

    void Start()
    {
        hitEffect = GetComponentInChildren<ParticleSystem>(true); // true to include inactive children
        if (hitEffect == null)
        {
            Debug.LogError("No Particle System found as a child of the ball. Please attach one.");
        }
        hitEffect.Stop();
    }

    void Update()
    {
        if (!isThrowing)
        {
            Vector2 ballStartScreenPos = Camera.main.WorldToScreenPoint(startPos);
            Vector2 mousePos = Mouse.current.position.ReadValue();
            transform.position = startPos + (Vector3)(mousePos - ballStartScreenPos) * followScaling;
        }
    }

    public IEnumerator Throw(Vector3 tarpos)
    {
        if (!isThrowing)
        {
            isThrowing = true;
            yield return StartCoroutine(FlyToTarget(transform, tarpos));
        }
    }

    IEnumerator FlyToTarget(Transform ball, Vector3 tarPos)
    {
        Vector3 throwStartPos = ball.position;
        float startTime = Time.time;
        Vector3 flyVec = tarPos - throwStartPos;
        while (Time.time - startTime < flyDuration)
        {
            ball.position = throwStartPos + (Time.time - startTime) / flyDuration * flyVec;
            yield return 0;
        }
    }

    public void ReturnToStartPos()
    {
        transform.localScale = new Vector3(1, 1, 1);
        Vector2 ballStartScreenPos = Camera.main.WorldToScreenPoint(startPos);
        Vector2 mousePos = Mouse.current.position.ReadValue();
        transform.position = startPos + (Vector3)(mousePos - ballStartScreenPos) * followScaling;
        isThrowing = false;
        transform.gameObject.SetActive(true);
    }

    public void PlayHitEffect()
    {
        if (hitEffect != null)
        {
            //hitEffect.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear); // Stop any existing effects and clear them
            hitEffect.Play(); // Play the effect
        }
        else
        {
            Debug.LogError("Hit effect is not assigned or found!");
        }
    }
}
