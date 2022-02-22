using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0, 0, 10);

    private void LateUpdate()
    {
        Vector3 position = transform.position;
        position.x = (player.position + offset).x;
        transform.position = position;
    }
}
