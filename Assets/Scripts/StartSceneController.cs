using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    void Start()
    {
        
    }

    public void AnimFinshed()
    {
        SceneManager.LoadScene("Menu");
    }
}
