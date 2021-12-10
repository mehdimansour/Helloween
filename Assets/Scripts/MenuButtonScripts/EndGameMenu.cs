using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    public GameObject endGameUI;

    public void PlayAgain()
    {
        endGameUI.SetActive(false);
        SceneManager.LoadScene("Menu" /*Game Scene*/);
    }

    public void ExitFromEndGame()
    {
        endGameUI.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
