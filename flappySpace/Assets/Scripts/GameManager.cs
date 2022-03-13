using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Game Manager Settings")]
    public GameObject deathScreen;

    public static GameManager instance;

    private float _slowdownFactor = 0.2f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        StartCoroutine(DelayedGameOver());
    }

    // Slow downed animation playing while game over screen shows on
    IEnumerator DelayedGameOver()
    {
        Time.timeScale = _slowdownFactor;

        deathScreen.SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);

        Time.timeScale = 0f;
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
}
