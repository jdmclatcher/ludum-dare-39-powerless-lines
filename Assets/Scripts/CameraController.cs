using UnityEngine;

public class CameraController : MonoBehaviour {

    private Animator theAnimator;

    private void Start()
    {
        theAnimator = GetComponent<Animator>();
    }

    public void OnDeathMoveCam()
    {
        theAnimator.SetTrigger("Camera Outro");
    }
}
