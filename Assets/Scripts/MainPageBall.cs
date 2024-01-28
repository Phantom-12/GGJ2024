using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainPageBall : MonoBehaviour
{
    bool isThrowing;
    Vector3 startPos;
    [SerializeField]
    float followScaling;
    [SerializeField]
    float flyDuration;

    void Awake()
    {
        isThrowing = false;
        startPos = transform.position;
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

    public void ThrowInputHandler(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            if (isThrowing)
                return;
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos.z = Camera.main.transform.position.z;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 100))
            {
                // Debug.Log(raycastHit.point);
                // Debug.Log(raycastHit.transform.gameObject.name);
                // Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.right, Color.red, 100);
                // Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.up, Color.red, 100);
                StartCoroutine(Throw(raycastHit.point));
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
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
            yield return new WaitForSeconds(1);
            ReturnToStartPos();
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
    }
}
