using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour {

    public GameObject splashScreen;

    private void Update()
    {
        if(!splashScreen.activeInHierarchy)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
