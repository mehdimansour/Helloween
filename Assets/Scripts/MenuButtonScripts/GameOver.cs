using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void Retry()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene("Menu" /*Game Scene*/);
    }

    public void ExitFromGameOver()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
