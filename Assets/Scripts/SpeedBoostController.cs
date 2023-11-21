/*using UnityEngine;

public class SpeedBoostController : MonoBehaviour {

    private PlayerController thePlayer;

    public float secondsTilDestroy;
    public float secondsTilDestroyStore;

    private void Start()
    {
        secondsTilDestroy = secondsTilDestroyStore;
        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    
        if(other.tag == "Rig")
        {
            thePlayer.horizontalMoveSpeed = thePlayer.horizontalMoveSpeed + 0.5f;
            thePlayer.verticalMoveSpeed = thePlayer.verticalMoveSpeed + 0.5f;
            thePlayer.speedParticleTrail.SetActive(true);
            Instantiate(thePlayer.speedParticleTrail, thePlayer.transform.position, thePlayer.transform.rotation);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        secondsTilDestroy -= Time.deltaTime;

        if (secondsTilDestroy <= 0)
        {
            Destroy(gameObject);
        }

    }
}*/
