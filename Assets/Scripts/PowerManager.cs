using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour {

    [SerializeField]
    private float maxPower = 100;

    private static float currentPower;

    public Slider powerBar;

    private PlayerController thePlayer;
    private CameraController theCamera;
    private ScoreManager theScoreManager;

    private bool dead;

    [SerializeField]
    private float timeSpeedMultiplier;

    public bool canSpeedUp;

    public AudioSource deathSFX;

    private void Start()
    {
        timeSpeedMultiplier = 1f;

        dead = false;

        theScoreManager = FindObjectOfType<ScoreManager>();

        theCamera = FindObjectOfType<CameraController>();

        thePlayer = FindObjectOfType<PlayerController>();

        powerBar = GetComponent<Slider>();

        currentPower = maxPower;
    }

    private void Update()
    {
        if(currentPower <= 0)
        {
            currentPower = 0;
            if(!dead)
            {
                Die();
                dead = true;
                currentPower = 0;
            }
               

        }

        if (currentPower > maxPower)
            currentPower = maxPower;

        if(theScoreManager.score >= 100 && theScoreManager.score <= 200)
        {
            timeSpeedMultiplier = 2f;
        }
        else if(theScoreManager.score >= 300 && theScoreManager.score <= 400)
        {
            timeSpeedMultiplier = 3f;
        }
        else if(theScoreManager.score >= 500 && theScoreManager.score <= 600)
        {
            timeSpeedMultiplier = 4f;
        }
        else if(theScoreManager.score >= 700 && theScoreManager.score <= 800)
        {
            timeSpeedMultiplier = 8f;
        }
        else if (theScoreManager.score >= 900)
        {
            timeSpeedMultiplier = 16f;
        }


        if (thePlayer.canMove)
        {
            currentPower -= Time.deltaTime * timeSpeedMultiplier;
        }
        

        powerBar.value = currentPower;
    }

    public static void GainPower(float _amount)
    {
        currentPower += _amount;

        Debug.Log("You now have " + currentPower + " power!");

        //Debug.Log("Gaining power...");
    }

    public static void LosePower(float _amount)
    {
        currentPower -= _amount;

        Debug.Log("You now have " + currentPower + " power!");

        //Debug.Log("Losing power...");


    }

    private void Die()
    {
        currentPower = 0;
        thePlayer.canPlay = false;
        thePlayer.canMove = false;

        theCamera.OnDeathMoveCam();

        Debug.Log("You got dead.");
    }

    public void PlayDeathSound()
    {
        deathSFX.Play();
    }

}
    
    

