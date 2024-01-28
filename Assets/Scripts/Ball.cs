using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    bool isThrowing;
    Vector3 startPos;

    [SerializeField]
    float followScaling;
    [SerializeField]
    float flyDuration;
    [SerializeField]
    float goalToHoopDuration, goalToGroundDuration;
    [SerializeField]
    float fadeDuration;
    [SerializeField]
    float hitRefereeToGroundSpeed;
    [SerializeField]
    Vector2 knockedDir;
    [SerializeField]
    float knockedAwayDuration, knockedAwaySpeed;

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
        // StopAllCoroutines();
        // if(isThrowing)
        //     transform.position = startPos;
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

    public IEnumerator GoalToHoop(Vector3 hoopPos, Vector3 groundPos)
    {
        Vector3 startPos = transform.position;
        Vector3 controlPoint = (startPos + hoopPos) / 2 + (startPos - hoopPos).magnitude * 0.8f * Vector3.up;
        float startTime = Time.time;
        while (Time.time - startTime < goalToHoopDuration)
        {
            transform.position = CalculateBezierPoint((Time.time - startTime) / goalToHoopDuration, startPos, controlPoint, hoopPos);
            yield return 0;
        }
    }

    public IEnumerator GoalToGround(Vector3 hoopPos, Vector3 groundPos)
    {
        float startTime = Time.time;
        Vector3 flyVec = groundPos - hoopPos;
        while (Time.time - startTime < goalToGroundDuration)
        {
            transform.position = hoopPos + (Time.time - startTime) / goalToGroundDuration * flyVec;
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
    }

    public IEnumerator Fade()
    {
        float startScale = 1f, endScale = 0f;
        float startTime = Time.time;
        while (Time.time - startTime < fadeDuration)
        {
            transform.localScale = Vector3.one * Mathf.Lerp(startScale, endScale, (Time.time - startTime) / fadeDuration);
            yield return 0;
        }
    }

    public IEnumerator HitReferee(Vector3 groundPos)
    {
        Vector3 startPos = transform.position;
        float startTime = Time.time;
        Vector3 flyVec = Vector3.down * (startPos.y - groundPos.y);
        float duration = (startPos.y - groundPos.y) / hitRefereeToGroundSpeed;
        while (Time.time - startTime < duration)
        {
            transform.position = startPos + (Time.time - startTime) / duration * flyVec;
            yield return 0;
        }
    }

    public IEnumerator KnockedAway()
    {
        float startTime = Time.time;
        knockedDir.Normalize();
        while (Time.time - startTime < knockedAwayDuration)
        {
            transform.position = transform.position + (Vector3)(knockedAwaySpeed * knockedDir);
            yield return 0;
        }
    }

    Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        // Applying the quadratic Bezier formula
        return Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
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
