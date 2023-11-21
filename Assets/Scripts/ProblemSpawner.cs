using UnityEngine;

public class ProblemSpawner : MonoBehaviour {

    public GameObject sparks;

    [SerializeField]
    private float minSecondsTilSpawn;
    [SerializeField]
    private float maxSecondsTilSpawn;
    [SerializeField]
    private float secondsTilFirstSpawn;

    [SerializeField]
    private float minSecondsTilSpawnStore;
    [SerializeField]
    private float maxSecondsTilSpawnStore;

    private PlayerController thePlayer;
    private ScoreManager theScoreManager;

    [SerializeField]
    private float speedSubtraction;

    public bool canSpeedUp;

    private void Start()
    {
        minSecondsTilSpawn = minSecondsTilSpawnStore;
        maxSecondsTilSpawn = maxSecondsTilSpawnStore;

        canSpeedUp = true;
        thePlayer = FindObjectOfType<PlayerController>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        Invoke("SpawnProblemFirstTime", secondsTilFirstSpawn);
    }

    private void SpawnProblem()
    {
        if(thePlayer.canPlay)
        {
            //Spawns problem in a random spot based on values
            Instantiate(sparks, new Vector3(Random.Range(-8f, 8.4f), Random.Range(3.4f, -1.24f), transform.position.z), sparks.transform.rotation);


            //Spawns new problem in random time
            Invoke("SpawnProblem", Random.Range(minSecondsTilSpawn, maxSecondsTilSpawn));
        }
        
   
    }

    private void SpawnProblemFirstTime()
    {
        Instantiate(sparks, new Vector3(Random.Range(-8f, 8.4f), Random.Range(3.4f, 2f), transform.position.z), sparks.transform.rotation);

        Invoke("SpawnProblem", Random.Range(minSecondsTilSpawn, maxSecondsTilSpawn));
    }

    private void Update()
    {
        if(theScoreManager.score >= 200 && canSpeedUp)
        {
            ReduceSpawnSpeed();
            canSpeedUp = false;
        }

        
    }

    private void ReduceSpawnSpeed()
    {
        minSecondsTilSpawn = minSecondsTilSpawn - speedSubtraction;
        maxSecondsTilSpawn = maxSecondsTilSpawn - speedSubtraction;
    }
}
