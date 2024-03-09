using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public static GameBehaviour Instance;
    [SerializeField] Animator transitionAnim;
    [SerializeField] GameObject volumeControlUI;

    private string sceneName;

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

    public void SceneToMoveTo(string sceneName)
    {
        StartCoroutine(LoadLevel(sceneName));
        //SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionSelection()
    {
        volumeControlUI.SetActive(true);
        return;
    }

    IEnumerator LoadLevel(string sceneName)
    {
        transitionAnim.SetTrigger("LevelEnd");
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(sceneName);
        transitionAnim.SetTrigger("LevelStart");
    }
}
