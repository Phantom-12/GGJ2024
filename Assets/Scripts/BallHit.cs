using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "StartTag")
        {
            GameBehaviour.Instance.SceneToMoveTo("LevelSelect");
        }
        else if (collision.gameObject.tag == "ExitTag")
        {
            GameBehaviour.Instance.ExitGame();
        }
    }
}
