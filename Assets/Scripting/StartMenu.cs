using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}