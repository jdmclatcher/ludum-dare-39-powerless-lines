using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour {

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
