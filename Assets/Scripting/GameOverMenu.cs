using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public TMP_Text finalScoreText;

    private void Start()
    {
        finalScoreText.text = "score: " +
        PlayerPrefs.GetInt("Score", 0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0); 
    }
}