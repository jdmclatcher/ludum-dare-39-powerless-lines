using UnityEngine;
using UnityEngine.SceneManagement;

public class DeactivateOverTime : MonoBehaviour {

    public float timeTilDeactivate;

    private void Start()
    {
        //gameObject.SetActive(true);
    }

    private void Update()
    {
        timeTilDeactivate -= Time.deltaTime;

        if (timeTilDeactivate <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
