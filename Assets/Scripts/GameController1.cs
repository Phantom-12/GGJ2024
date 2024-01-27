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
    Transform hoopPos,goalGroundPos;
    [SerializeField]
    Transform hitRefereeGroundPos;

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip knockBall,whistling,boos,hurt,undressing,goal;

    bool isPlaying;


    public void ThrowInputHandler(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            if(isPlaying)
                return ;
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
        isPlaying=true;
        yield return StartCoroutine(ball.Throw(tarpos));
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying=false;
    }
    
    IEnumerator HitPlayerFace(Vector3 tarpos)
    {
        isPlaying=true;
        yield return StartCoroutine(ball.Throw(tarpos));

        hoopSpriteRenderer.sortingOrder=30;
        PlayAudio(hurt);
        player.HitFace();
        yield return StartCoroutine(ball.GoalToHoop(hoopPos.position,goalGroundPos.position));
        PlayAudio(goal);
        yield return StartCoroutine(ball.GoalToGround(hoopPos.position,goalGroundPos.position));
        hoopSpriteRenderer.sortingOrder=10;

        yield return new WaitForSeconds(1);
        player.Init();
        ball.ReturnToStartPos();
        isPlaying=false;
    }
    
    IEnumerator HitAudience(Vector3 tarpos)
    {
        isPlaying=true;
        yield return StartCoroutine(ball.Throw(tarpos));
        PlayAudio(boos);
        yield return StartCoroutine(ball.Fade());
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying=false;
    }
    
    IEnumerator HitReferee(Vector3 tarpos)
    {
        isPlaying=true;
        yield return StartCoroutine(ball.Throw(tarpos));
        PlayAudio(whistling);
        yield return StartCoroutine(ball.HitReferee(hitRefereeGroundPos.position));
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying=false;
    }
    
    IEnumerator HitHoop(Vector3 tarpos)
    {
        isPlaying=true;
        StartCoroutine(ball.Throw(tarpos));
        yield return new WaitForSeconds(0.2f);
        yield return StartCoroutine(referee.FlyToBall(tarpos));
        PlayAudio(knockBall);

        Coroutine temp = StartCoroutine(ball.KnockedAway());
        yield return StartCoroutine(referee.BackToGround(goalGroundPos.position));

        yield return StartCoroutine(referee.Act());
        PlayAudio(undressing);
        StopCoroutine(temp);
        
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        referee.Init();
        isPlaying=false;
    }

    void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip=audioClip;
        audioSource.Play();
    }
}
