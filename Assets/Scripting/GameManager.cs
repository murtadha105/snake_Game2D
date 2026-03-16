using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMP_Text scoreText;
    private int _score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore()
    {
        _score++;
        scoreText.text = "Score: " + _score;
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("Score", _score);
        SceneManager.LoadScene(2); 
    }
}