using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text theScoreText;
    public Text theHighScoreText;

    public float score;
    private float highScore;

    [SerializeField]
    private float pointsPerSecond;

    [SerializeField]
    private bool scoreIncreasing;

    private PlayerController thePlayer;

    private void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
        }

        thePlayer = FindObjectOfType<PlayerController>();

        scoreIncreasing = false;
    }

    private void Update()
    {
        if(thePlayer.canMove)
        {
            scoreIncreasing = true;
        }
        if(thePlayer.canPlay == false)
        {
            scoreIncreasing = false;
        }

        if (scoreIncreasing)
        {
            score += Time.deltaTime * pointsPerSecond;
        }
          

        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }
        

        theScoreText.text = " " + Mathf.Round(score);
        theHighScoreText.text = " " + Mathf.Round(highScore);
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }


}
