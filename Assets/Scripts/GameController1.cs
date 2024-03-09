using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController1 : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer hoopSpriteRenderer;

    [SerializeField]
    Ball ball;
    [SerializeField]
    Player player;
    [SerializeField]
    Referee referee;
    [SerializeField]
    Transform hoopPos, goalGroundPos;
    [SerializeField]
    Transform hitRefereeGroundPos;

    [SerializeField]
    GameObject UIRetry, UINextScene;
    [SerializeField]
    GameObject toudi, wulong, quzhu;

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip trueEnding, badEnding, knockBall, whistling, boos, hurt, undressing, goal, throwing;

    bool isPlaying;

    void Start()
    {
        UIRetry.SetActive(false);
        UINextScene.SetActive(false);
        toudi.SetActive(false);
        wulong.SetActive(false);
        quzhu.SetActive(false);
    }


    public void ThrowInputHandler(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            if (isPlaying)
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
                switch (raycastHit.transform.gameObject.name)
                {
                    case "ground":
                        StartCoroutine(HitGround(raycastHit.point));
                        break;
                    case "playerFace":
                        StartCoroutine(HitPlayerFace(raycastHit.point));
                        break;
                    case "audience":
                        StartCoroutine(HitAudience(raycastHit.point));
                        break;
                    case "referee":
                        StartCoroutine(HitReferee(raycastHit.point));
                        break;
                    case "hoop":
                        StartCoroutine(HitHoop(raycastHit.point));
                        break;
                }
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }

    IEnumerator HitGround(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(ball.Throw(tarpos));
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitPlayerFace(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(ball.Throw(tarpos));

        hoopSpriteRenderer.sortingOrder = 30;
        audioSource.PlayOneShot(hurt);
        player.HitFace();
        yield return StartCoroutine(ball.GoalToHoop(hoopPos.position, goalGroundPos.position));
        audioSource.PlayOneShot(goal);
        yield return StartCoroutine(ball.GoalToGround(hoopPos.position, goalGroundPos.position));
        hoopSpriteRenderer.sortingOrder = 10;

        yield return new WaitForSeconds(1);
        // player.Init();
        // ball.ReturnToStartPos();
        // isPlaying=false;
        wulong.SetActive(true);
        audioSource.PlayOneShot(trueEnding);
        UINextScene.SetActive(true);
    }

    IEnumerator HitAudience(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(ball.Throw(tarpos));
        audioSource.PlayOneShot(boos);
        yield return StartCoroutine(ball.Fade());
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitReferee(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(ball.Throw(tarpos));
        audioSource.PlayOneShot(whistling);
        yield return StartCoroutine(ball.HitReferee(hitRefereeGroundPos.position));
        yield return new WaitForSeconds(1);
        // ball.ReturnToStartPos();
        // isPlaying=false;
        quzhu.SetActive(true);
        audioSource.PlayOneShot(badEnding);
        UIRetry.SetActive(true);
    }

    IEnumerator HitHoop(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        StartCoroutine(ball.Throw(tarpos));
        yield return new WaitForSeconds(0.2f);
        yield return StartCoroutine(referee.FlyToBall(tarpos));
        audioSource.PlayOneShot(knockBall);

        Coroutine temp = StartCoroutine(ball.KnockedAway());
        yield return StartCoroutine(referee.BackToGround(goalGroundPos.position));

        yield return StartCoroutine(referee.Act());
        audioSource.PlayOneShot(undressing);
        StopCoroutine(temp);

        yield return new WaitForSeconds(1);
        // ball.ReturnToStartPos();
        // referee.Init();
        // isPlaying=false;
        toudi.SetActive(true);
        audioSource.PlayOneShot(badEnding);
        UIRetry.SetActive(true);
    }
}
