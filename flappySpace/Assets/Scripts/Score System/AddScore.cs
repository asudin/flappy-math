using UnityEngine;

public class AddScore : MonoBehaviour
{

    [SerializeField] private AudioSource _sucessPing;

    private void Start()
    {
        _sucessPing = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score._score += 10;
        _sucessPing.Play();
    }
}