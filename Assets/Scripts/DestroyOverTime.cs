using UnityEngine;

public class DestroyOverTime : MonoBehaviour {

    private float timeTilDeath;
    public float destroyOverTimeStore;

	// Use this for initialization
	void Start () {
        timeTilDeath = destroyOverTimeStore;
	}
	
	// Update is called once per frame
	void Update () {
        timeTilDeath -= Time.deltaTime;

        if (timeTilDeath <= 0)
            Destroy(gameObject);
	}
}
