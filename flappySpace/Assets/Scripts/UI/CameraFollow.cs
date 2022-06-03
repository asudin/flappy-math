using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    private Vector3 _offset = new Vector3(0, 0, 10);

    private void LateUpdate()
    {
        // If the player hasn't been destroyed
        if (Player != null)
        {
            // Camera follows the player
            Vector3 position = transform.position;
            position.x = (Player.position + _offset).x;
            transform.position = position;
        }
    }
}
