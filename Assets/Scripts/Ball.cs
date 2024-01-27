using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private bool isThrowing;
    Vector3 startPos;
    [SerializeField]
    float flyDuration = 1.5f;
    [SerializeField]
    float returnDelay = 1.5f;

    void Awake()
    {
        isThrowing = false;
        startPos = transform.position;
    }

    public void ThrowInputHandler(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos.z = Camera.main.transform.position.z;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 100))
            {
                Debug.Log(raycastHit.point);
                Debug.Log(raycastHit.transform.gameObject.name);
                Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.right, Color.red, 100);
                Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.up, Color.red, 100);
                Throw(raycastHit.point);
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }

    void Throw(Vector3 tarpos)
    {
        StopAllCoroutines();
        transform.position = startPos;
        StartCoroutine(FlyToTarget(transform, tarpos));
    }

    IEnumerator FlyToTarget(Transform ball, Vector3 tarPos)
    {
        float startTime = Time.time;
        Vector3 flyVec = tarPos - startPos;
        while (Time.time - startTime < flyDuration)
        {
            ball.position = startPos + (Time.time - startTime) / flyDuration * flyVec;
            yield return 0;
        }
        StartCoroutine(ReturnToStartPos(ball));
    }

    IEnumerator ReturnToStartPos(Transform ball)
    {
        yield return new WaitForSeconds(returnDelay);
        ball.position = startPos;
    }
}
