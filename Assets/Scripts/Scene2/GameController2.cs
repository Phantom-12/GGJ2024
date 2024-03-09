using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class GameController2 : MonoBehaviour
{
    bool isPlaying;

    [SerializeField]
    Trash trash;
    [SerializeField]
    Cover cover;
    [SerializeField]
    Transform coverGroundPoint;
    [SerializeField]
    Cop cop;
    [SerializeField]
    Plane plane;
    [SerializeField]
    Transform planeBinPoint;

    [SerializeField]
    GameObject UIRetry, UINextScene;
    [SerializeField]
    GameObject gai, gongde, laji;

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip trueEnding, badEnding, throwing, gaiban, dishang, jingcha, polie;

    void Start()
    {
        UIRetry.SetActive(false);
        UINextScene.SetActive(false);
        gai.SetActive(false);
        gongde.SetActive(false);
        laji.SetActive(false);
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
                    case "cover":
                        StartCoroutine(HitCover(raycastHit.point));
                        break;
                    case "ground":
                        StartCoroutine(HitGround(raycastHit.point));
                        break;
                    case "nothing":
                        StartCoroutine(HitNothing(raycastHit.point));
                        break;
                    case "plane":
                        StartCoroutine(HitPlane(raycastHit.point));
                        break;
                }
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }

    IEnumerator HitNothing(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(trash.Throw(tarpos));

        yield return StartCoroutine(trash.Fade());
        yield return new WaitForSeconds(1);
        trash.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitCover(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(trash.Throw(tarpos));

        audioSource.PlayOneShot(gaiban);
        StartCoroutine(cover.CloseTheCover());
        yield return StartCoroutine(trash.CoverToGround(coverGroundPoint.position));

        yield return new WaitForSeconds(1);

        gai.SetActive(true);
        audioSource.PlayOneShot(badEnding);
        UIRetry.SetActive(true);
    }

    IEnumerator HitGround(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(trash.Throw(tarpos));
        audioSource.PlayOneShot(dishang);
        yield return StartCoroutine(cop.ToTrash(tarpos));

        yield return new WaitForSeconds(1);

        gongde.SetActive(true);
        audioSource.PlayOneShot(badEnding);
        UIRetry.SetActive(true);

        // trash.ReturnToStartPos();
        // isPlaying = false;
    }

    IEnumerator HitPlane(Vector3 tarpos)
    {
        isPlaying = true;
        audioSource.PlayOneShot(throwing);
        yield return StartCoroutine(trash.Throw(tarpos));

        StartCoroutine(trash.Fade());
        yield return StartCoroutine(plane.ToBin(planeBinPoint.position));
        audioSource.PlayOneShot(polie);

        yield return new WaitForSeconds(1);

        laji.SetActive(true);
        audioSource.PlayOneShot(trueEnding);
        UINextScene.SetActive(true);

        // trash.ReturnToStartPos();
        // isPlaying = false;
    }
}
