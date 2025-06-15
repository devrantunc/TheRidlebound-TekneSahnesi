using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLimit = 60f;
    private float timeRemaining;

    public Text timerText;
    public GameObject losePanel;
    public GameObject WinPanel;

    private bool gameOver = false;

    void Start()
    {
        timeRemaining = timeLimit;
        losePanel.SetActive(false);
    }

    void Update()
    {
        if (gameOver) return;

        timeRemaining -= Time.deltaTime;
        timerText.text = "Süre: " + Mathf.Ceil(timeRemaining).ToString();

        if (timeRemaining <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOver = true;
        losePanel.SetActive(true);
        Invoke("RestartGame", 3f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        gameOver = true;
        WinPanel.SetActive(true);
        Invoke("RestartGame", 3f);
    }
}