using UnityEngine;

public class AddScore : MonoBehaviour
{
    // adding score on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score += 10;
    }
}