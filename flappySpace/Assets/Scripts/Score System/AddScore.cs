using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Adding score on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score._score += 10;
    }
}