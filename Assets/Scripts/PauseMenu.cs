using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool isPaused;
    public bool canPause;

    public GameObject pauseMenuCanvas;

    private void Start()
    {
        //gameObject.SetActive(false);
        canPause = true;
    }

    private void Update()
    {
        if(isPaused && canPause)
        {
            AudioListener.pause = true;
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            AudioListener.pause = false;
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            isPaused = !isPaused;
        }
    }

    public void PauseUnpause()
    {

        isPaused = !isPaused;
    }

    public void Resume()
    {

        isPaused = false;
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
