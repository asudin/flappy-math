using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _jumpVelocity = 4f;
    [SerializeField] private float _speed = 0.5f;

    public AudioSource jumpSound;
    public GameObject deathEffect;

    private Rigidbody2D rb;
    private ParticleSystem jumpEffect;

    [Header("Game settings")]
    public GameManager gameManager; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpEffect = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        PlayerMove();
    }

    // Player movement & jumping
    void PlayerMove()
    {
        transform.position += Vector3.right * _speed * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * _jumpVelocity;

            // Adding particle jump & sound effects
            jumpEffect.Play();
            jumpSound.Play();
        }
    }

    // Showing death screen on player collision with walls
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();

        // Destroy the player and shows off dead particles
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Game over screen when player outside of screen boundaries
    void OnBecameInvisible()
    {
        gameManager.GameOver();
        Destroy(gameObject);
    }
}
