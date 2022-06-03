using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Game Manager Settings")]
    public GameObject DeathScreen;

    public static GameManager Instance;

    private float _slowdownFactor = 0.2f;

    private void Awake()
    {
        if ((Instance == null) == false)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        StartCoroutine(DelayedGameOver());
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator DelayedGameOver()
    {
        Time.timeScale = _slowdownFactor;

        DeathScreen.SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);

        Time.timeScale = 0f;
    }
}
