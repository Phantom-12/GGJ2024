using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameControllerMainMenu : MonoBehaviour
{   
    [SerializeField]
    Ball ball;

    [SerializeField]
    GameObject volumnControlUI;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip UIHitNothing,UIHitButton;

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
                    case "StartObj":
                        StartCoroutine(HitStartButton(raycastHit.point));
                        break;
                    case "ExitObj":
                        StartCoroutine(HitExitButton(raycastHit.point));
                        break;
                    case "OptionObj":
                        StartCoroutine(HitOptionButton(raycastHit.point));
                        break;
                    case "LevelOneObj":
                        StartCoroutine(HitLevelOneButton(raycastHit.point));
                        break;
                    case "LevelTwoObj":
                        StartCoroutine(HitLevelTwoButton(raycastHit.point));
                        break;
                    case "LevelThreeObj":
                        StartCoroutine(HitLevelThreeButton(raycastHit.point));
                        break;
                    case "LevelFourObj":
                        StartCoroutine(HitLevelFourButton(raycastHit.point));
                        break;
                    case "LockedObj":
                        StartCoroutine(HitLockedLevelButton(raycastHit.point));
                        break;
                    case "BackObj":
                        StartCoroutine(HitBackButton(raycastHit.point));
                        break;
                    case "nothing":
                        StartCoroutine(HitNothing(raycastHit.point));
                        break;
                }
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }
    IEnumerator HitNothing(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(UIHitNothing);
        yield return StartCoroutine(ball.Throw(tarpos));
        yield return new WaitForSeconds(1);
        ball.ReturnToStartPos();
        isPlaying=false;
    }

    IEnumerator HitStartButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("LevelSelect");
    }

    IEnumerator HitExitButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.ExitGame();
    }

    IEnumerator HitOptionButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        ball.ReturnToStartPos();
        volumnControlUI.SetActive(true);
    }

    IEnumerator HitLevelOneButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("Scene1");
    }

    IEnumerator HitLevelTwoButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("Scene4");
    }

    IEnumerator HitLevelThreeButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("Scene2");
    }

    IEnumerator HitLevelFourButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("Scene3");
    }

    IEnumerator HitBackButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        isPlaying = false;
        GameBehaviour.Instance.SceneToMoveTo("Menu");
    }

    IEnumerator HitLockedLevelButton(Vector3 tarpos)
    {
        isPlaying = true;
        yield return StartCoroutine(ball.Throw(tarpos));
        //audioSource.PlayOneShot(whistling);
        ball.PlayHitEffect();
        audioSource.PlayOneShot(UIHitButton);
        yield return new WaitForSeconds(0.5f);
        ball.ReturnToStartPos();
        isPlaying = false;
    }

    // void PlayAudio(AudioClip audioClip)
    // {
    //     audioSource.clip=audioClip;
    //     audioSource.Play();
    // }
}
