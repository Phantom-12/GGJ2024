using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class GameController3 : MonoBehaviour
{
    bool isPlaying;

    [SerializeField]
    Knife knife;
    [SerializeField]
    Apple apple1,apple2,apple3;
    [SerializeField]
    Foundation foundation;
    [SerializeField]
    ClownAndBoard clownAndBoard;
    [SerializeField]
    Curtain curtain;
    [SerializeField]
    GameObject water,blood;

    [SerializeField]
    GameObject UIRetry, UINextScene;
    [SerializeField]
    GameObject yingtao, gaoshou, baotou;

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip throwing, eat, dodge, turnoff, tom, blade;

    void Start()
    {
        UIRetry.SetActive(false);
        UINextScene.SetActive(false);
        water.SetActive(false);
        blood.SetActive(false);
        yingtao.SetActive(false);
        gaoshou.SetActive(false);
        baotou.SetActive(false);
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
                Debug.Log(raycastHit.transform.gameObject.name);
                // Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.right, Color.red, 100);
                // Debug.DrawLine(raycastHit.point, raycastHit.point + Vector3.up, Color.red, 100);
                switch (raycastHit.transform.gameObject.name)
                {
                    case "apple1":
                        StartCoroutine(HitApple(raycastHit.point,1));
                        break;
                    case "apple2":
                        StartCoroutine(HitApple(raycastHit.point,2));
                        break;
                    case "apple3":
                        StartCoroutine(HitApple(raycastHit.point,3));
                        break;
                    case "clown":
                        StartCoroutine(HitClown(raycastHit.point));
                        break;
                    case "board":
                        StartCoroutine(HitBoard(raycastHit.point));
                        break;
                    case "woman":
                        StartCoroutine(HitWoman(raycastHit.point));
                        break;
                    case "foundation":
                        StartCoroutine(HitFoundation(raycastHit.point));
                        break;
                    case "curtain":
                        StartCoroutine(HitCurtain(raycastHit.point));
                        break;
                    
                }
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }
    
    IEnumerator HitApple(Vector3 tarpos,int appleId)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        switch(appleId)
        {
            case 1:
                yield return StartCoroutine(apple1.Hit());
                break;
            case 2:
                yield return StartCoroutine(apple2.Hit());
                break;
            case 3:
                yield return StartCoroutine(apple3.Hit());
                break;
        }

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UIRetry.SetActive(true);
    }

    IEnumerator HitClown(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        blood.transform.position=tarpos;
        blood.SetActive(true);

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UIRetry.SetActive(true);
    }

    IEnumerator HitBoard(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        water.SetActive(true);

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UIRetry.SetActive(true);
    }

    IEnumerator HitWoman(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        blood.transform.position=tarpos;
        blood.SetActive(true);

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UIRetry.SetActive(true);
    }

    IEnumerator HitFoundation(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        StartCoroutine(foundation.Hit());
        apple1.gameObject.SetActive(false);
        apple2.gameObject.SetActive(false);
        apple3.gameObject.SetActive(false);
        yield return StartCoroutine(clownAndBoard.Fall());

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UINextScene.SetActive(true);
    }

    IEnumerator HitCurtain(Vector3 tarpos)
    {
        isPlaying=true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(knife.Throw(tarpos));

        yield return StartCoroutine(curtain.Close());

        yield return new WaitForSeconds(1);
        yingtao.SetActive(true);
        UINextScene.SetActive(true);
    }
}
