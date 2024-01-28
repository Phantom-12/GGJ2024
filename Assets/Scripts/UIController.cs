using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public void ToScene(string name)
    {
        GameBehaviour.Instance.SceneToMoveTo(name);
    }
}
