using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField]
    float toBinDuration;

    public IEnumerator ToBin(Vector3 binPos)
    {
        Vector3 startPos = transform.position;
        Vector3 controlPoint = (startPos + binPos) / 2 + (startPos - binPos).magnitude * 0.8f * Vector3.up;
        float startTime = Time.time;
        while (Time.time - startTime < toBinDuration)
        {
            transform.position = CalculateBezierPoint((Time.time - startTime) / toBinDuration, startPos, controlPoint, binPos);
            yield return 0;
        }
    }    
    
    Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        // Applying the quadratic Bezier formula
        return Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
    }
}
