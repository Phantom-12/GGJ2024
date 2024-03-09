using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cop : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;

    public IEnumerator ToTrash(Vector3 trashPos)
    {
        Vector3 startPos = transform.position;
        float startTime = Time.time;
        Vector3 moveVec = Vector3.right * (trashPos.x - startPos.x);
        float duration = (trashPos.x - startPos.x) / moveSpeed;
        // Debug.Log(moveVec);
        // Debug.Log(duration);
        while (Time.time - startTime < duration)
        {
            transform.position = startPos + (Time.time - startTime) / duration * moveVec;
            yield return 0;
        }
    }
}
