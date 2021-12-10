using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
    }

    public void ExitFromPauseMenu()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
