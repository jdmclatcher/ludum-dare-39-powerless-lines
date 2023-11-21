using UnityEngine;


public class ProblemController : MonoBehaviour {

    [SerializeField]
    private float timeTilDestroy;

    public float powerGainAmount;

    public float powerLoseAmount;

    public GameObject deathParticle;
    public GameObject lifeParticle;

    //public AudioSource deathSFX;

    private PowerManager thePowerManager;

    //private AudioSource personalSpeakers;

    public bool hasCollided;

    private void Start()
    {
        hasCollided = false;

        //personalSpeakers = GetComponent<AudioSource>();
        thePowerManager = FindObjectOfType<PowerManager>();

        //personalSpeakers.Play();
    }

    private void Update()
    {

        timeTilDestroy -= Time.deltaTime;

        /*if(timeTilDestroy <= 0.5f)
        {
            deathSFX.Play();
        }*/

        if (timeTilDestroy <= 0)
        {
            thePowerManager.PlayDeathSound();
            Instantiate(deathParticle, transform.position, transform.rotation);
            PowerManager.LosePower(powerLoseAmount);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rig" && !hasCollided)
        {       
            Instantiate(lifeParticle, transform.position, transform.rotation);
            PowerManager.GainPower(powerGainAmount);
            Destroy(gameObject);
            hasCollided = true;
        }

    }


}
