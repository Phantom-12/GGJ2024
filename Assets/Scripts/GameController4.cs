using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class GameController4 : MonoBehaviour
{
    bool isPlaying;

    [SerializeField]
    GameObject cakePart1,cakePart2,cakePart3,cakePart4;
    [SerializeField]
    GameObject candle,cherry;

    [SerializeField]
    Cake cake;    
    [SerializeField]
    Triangle triangle;
    [SerializeField]
    Circle circle;
    [SerializeField]
    Square square;
    [SerializeField]
    BigCake bigCake;
    [SerializeField]
    GameObject darkness;

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip throwing,eat,dodge,turnoff,tom,blade;

    void Start()
    {
        cakePart1.SetActive(false);
        cakePart2.SetActive(false);
        cakePart3.SetActive(false);
        cakePart4.SetActive(false);
        candle.SetActive(false);
        cherry.SetActive(false);
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
                    case "triangle":
                        StartCoroutine(HitTriangle(raycastHit.point));
                        break;
                    case "circle":
                        StartCoroutine(HitCircle(raycastHit.point));
                        break;
                    case "square":
                        StartCoroutine(HitSquare(raycastHit.point));
                        break;
                    case "bigCake":
                        StartCoroutine(HitBigCake(raycastHit.point));
                        break;
                }
            }
            // Debug.DrawRay(ray.origin,ray.direction,Color.red,100);
            // Debug.Log(ray);
        }
    }

    IEnumerator HitTriangle(Vector3 tarpos)
    {
        isPlaying = true;
        PlayAudio(throwing);
        yield return StartCoroutine(cake.Throw(tarpos));

        yield return StartCoroutine(triangle.Eat());
        PlayAudio(eat);
        cake.gameObject.SetActive(false);

        yield return new WaitForSeconds(1);
        cake.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitCircle(Vector3 tarpos)
    {
        isPlaying = true;
        PlayAudio(throwing);
        yield return StartCoroutine(cake.Throw(tarpos));

        circle.RandomMove();
        PlayAudio(dodge);
        yield return new WaitForSeconds(0.5f);
        circle.ReturnToStartPos();

        yield return new WaitForSeconds(1);
        cake.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitSquare(Vector3 tarpos)
    {
        isPlaying = true;
        PlayAudio(throwing);
        yield return StartCoroutine(cake.Throw(tarpos));

        darkness.SetActive(true);
        cake.gameObject.SetActive(false);
        PlayAudio(turnoff);
        //TODO:刀剑特效
        PlayAudio(blade);
        yield return new WaitForSeconds(1);

        darkness.SetActive(false);
        cakePart1.SetActive(true);
        cakePart2.SetActive(true);
        cakePart3.SetActive(true);
        cakePart4.SetActive(true);
        yield return StartCoroutine(square.Sword());

        yield return new WaitForSeconds(1);
        cakePart1.SetActive(false);
        cakePart2.SetActive(false);
        cakePart3.SetActive(false);
        cakePart4.SetActive(false);
        cake.ReturnToStartPos();
        isPlaying = false;
    }

    IEnumerator HitBigCake(Vector3 tarpos)
    {
        isPlaying = true;
        PlayAudio(throwing);
        yield return StartCoroutine(cake.Throw(tarpos));

        bigCake.LightOff();
        yield return new WaitForSeconds(0.5f);
        darkness.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        PlayAudio(tom);
        yield return new WaitForSeconds(2.5f);
        PlayAudio(turnoff);
        bigCake.gameObject.SetActive(false);
        cake.gameObject.SetActive(false);
        candle.SetActive(true);
        cherry.SetActive(true);
        darkness.SetActive(false);

        yield return new WaitForSeconds(1);
        candle.SetActive(false);
        cherry.SetActive(false);
        bigCake.Init();
        cake.ReturnToStartPos();
        isPlaying = false;
    }

    void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
