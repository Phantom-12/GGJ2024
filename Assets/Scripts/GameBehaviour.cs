using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public static GameBehaviour Instance;
    [SerializeField] Animator transitionAnim;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SceneToMoveTo()
    {
        StartCoroutine(LoadLevel());
        //SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionSelection()
    {
        //TODO: pop up options on a menu
        return;
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("LevelEnd");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
        transitionAnim.SetTrigger("LevelStart");
    }
}
