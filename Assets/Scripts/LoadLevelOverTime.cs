using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOverTime : MonoBehaviour {

    public float timeTilLoad;

    public string levelToLoad;

    private void Update()
    {
        timeTilLoad -= Time.deltaTime;

        if(timeTilLoad <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }



}
