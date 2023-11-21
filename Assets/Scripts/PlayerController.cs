using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    public float horizontalMoveSpeed;

    public float verticalMoveSpeed;

    private float timeTilMove;

    public bool canMove;

    public bool canPlay;

    public GameObject problem;

    public AudioSource hammerSFX;

    //public GameObject speedParticleTrail;

    [SerializeField]
    private bool collidedWithProblem;

    /*public float secondsTilSpeedGoneStore;
    public float secondsTilSpeedGone;*/

    private void Start()
    {
        
        /*secondsTilSpeedGone = secondsTilSpeedGoneStore;
        speedParticleTrail.SetActive(false);*/
        canPlay = true;
        canMove = false;
        myRigidbody = GetComponent<Rigidbody2D>();
        timeTilMove = 3f;
    }

    private void Update()
    {
        timeTilMove -= Time.deltaTime;

        if (timeTilMove <= 0)
            canMove = true;

        /*if(speedParticleTrail.activeInHierarchy)
        {
            secondsTilSpeedGone -= Time.deltaTime;

            if(secondsTilSpeedGone <= 0)
            {
                speedParticleTrail.SetActive(false);
                horizontalMoveSpeed = 2f;
                verticalMoveSpeed = 3f;
            }
        }*/

        #region Movement
        //Move Right Check
        if (Input.GetAxis("Horizontal") > 0 && canMove)
        {
            myRigidbody.velocity = new Vector3(horizontalMoveSpeed, myRigidbody.velocity.y, 0);
        }

        //Move Left Check
        else if (Input.GetAxis("Horizontal") < 0 && canMove)
        {
            myRigidbody.velocity = new Vector3(-horizontalMoveSpeed, myRigidbody.velocity.y, 0);
        }

        //Stop Horizontal Input Check
        else
        {
            myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
        }

        //Move Up Check
        if(Input.GetAxis("Vertical") > 0 && canMove)
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, verticalMoveSpeed, 0);
        }

        //Move Down Check
        else if(Input.GetAxis("Vertical") < 0 && canMove)
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, -verticalMoveSpeed, 0);
        }

        //Stop Vertical Input Check
        else
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, 0f, 0f);
        }
        #endregion

        /*if(!problem.activeInHierarchy && !collidedWithProblem)
        {
            powerManager.LosePower();
        }*/
            

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Problem")
        {
            if(hammerSFX.isPlaying == false)
            {
                hammerSFX.Play();
            }
            
        }
    }

    
}
