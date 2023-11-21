using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour {

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
