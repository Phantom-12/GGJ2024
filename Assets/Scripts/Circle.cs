using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Vector3 startPos;

    [SerializeField]
    float moveRangeMin, moveRangeMax;

    void Start()
    {
        startPos = transform.position;
    }

    public void RandomMove()
    {
        transform.position = startPos + new Vector3((Random.value < 0.5 ? -1 : 1) * Random.Range(moveRangeMin, moveRangeMax),
                                                    (Random.value < 0.5 ? -1 : 1) * Random.Range(moveRangeMin, moveRangeMax));
    }

    public void ReturnToStartPos()
    {
        transform.position = startPos;
    }
}
