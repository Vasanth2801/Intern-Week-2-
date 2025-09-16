using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    

    private void LateUpdate()
    {
        offset = new Vector3(0, 0, -10);
        transform.position = player.transform.position + offset;
    }
}
