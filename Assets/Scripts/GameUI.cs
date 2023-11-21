using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

    private PlayerController thePlayer;

    [SerializeField]
    private float secondsTilSecondUI;

    public GameObject secondUI;

    public GameObject curtain;


    public GameObject powerUI;
    public GameObject pauseButton;

    private void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if(thePlayer.canPlay == false)
        {
            powerUI.SetActive(false);
            pauseButton.SetActive(false);
            secondsTilSecondUI -= Time.deltaTime;
        }

        if(secondsTilSecondUI <= 0)
        {
            ShowSecondUI();
        }

        /*if(Input.GetKeyDown(KeyCode.Escape))
        {      
            pauseMenu.SetActive(true);
            Time.timeScale = 0; 
        }*/
    }

    private void ShowSecondUI()
    {
        secondUI.SetActive(true);
    }

    public void LoadMainLevel()
    {
        curtain.SetActive(true);
    }

 
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
