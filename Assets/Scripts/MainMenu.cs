using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private void Start()
    {
        Time.timeScale = 1f; 
    }

    public void ClickedPlay()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void HowToPlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
