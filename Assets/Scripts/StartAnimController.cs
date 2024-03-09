using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimController : MonoBehaviour
{
    [SerializeField]
    StartSceneController startSceneController;

    public void AnimFinshed()
    {
        startSceneController.AnimFinshed();
    }
}
