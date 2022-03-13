using UnityEngine;

public class AddScore : MonoBehaviour
{

    [SerializeField] private AudioSource _sucessPing;

    private void Start()
    {
        _sucessPing = GetComponent<AudioSource>();
    }
    // Adding score on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score._score += 10;
        _sucessPing.Play();
    }
}