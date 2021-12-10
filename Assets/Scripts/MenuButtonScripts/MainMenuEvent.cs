using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuEvent : MonoBehaviour 
{
    // Start is called before the first frame update

    public GameObject menuUi;

    public void PlayButton()
    {
        /*
        Debug.Log("Play Button");
        Animator anim = GetComponent<Animator>();

        anim.Play("ExitButton");*/
        menuUi.SetActive(false);
        SceneManager.LoadScene("Menu"/*Game Scene*/);


    }

    public void Exit()
    {
        Application.Quit();
    }
}
