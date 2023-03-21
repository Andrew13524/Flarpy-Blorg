using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI ScoreText;
    public GameObject GameOverScreen;

    public void AddScore()
    {
        score += 1;
        ScoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
