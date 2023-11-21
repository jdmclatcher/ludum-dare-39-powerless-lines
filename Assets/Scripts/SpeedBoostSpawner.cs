/*using UnityEngine;

public class SpeedBoostSpawner : MonoBehaviour {

    public GameObject speedBoost;

    [SerializeField]
    private float minSecondsToSpawn;
    [SerializeField]
    private float maxSecondsToSpawn;
    [SerializeField]
    private float secondsToFirstSpawn;

    public Transform point1;
    public Transform point2;

    private void Start () {
        Invoke("SpawnSpeedBoost", secondsToFirstSpawn);
	}

    private void SpawnSpeedBoost()
    {
        int i = Random.Range(1, 3);

        if (i == 1)
        {
            Instantiate(speedBoost, point1.transform.position, point1.transform.rotation); 

        }
        if (i == 2)
        {
            Instantiate(speedBoost, point2.transform.position, point2.transform.rotation);
        }

        Invoke("SpawnSpeedBoost", Random.Range(minSecondsToSpawn, maxSecondsToSpawn));

        
    }
	
    
	
}*/

