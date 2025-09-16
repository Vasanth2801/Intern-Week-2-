using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;                          //Reference to the player
    public Vector3 offset;                           // the values for camera to look at a distance or camera offset
    [SerializeField] private float smoothSpeed = 0.25f;       //smoohting of the camera to follow
    Vector3 currentVelocity;                              // local velocity movement 

    //Late Update is called after all functions
    private void LateUpdate()
    {
        MoveCamera();                    //Method to call Camera movement
    }

    // Method for the player movement
    void MoveCamera()
    {
        offset = new Vector3(0, 0, -10);          //offset values for the camera
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref currentVelocity, smoothSpeed);   //Mathimatical method for the Smoothing function method
    }
}
