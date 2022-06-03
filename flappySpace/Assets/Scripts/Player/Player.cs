using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    public AudioSource JumpSound;
    public GameObject DeathEffect;

    private Rigidbody2D _rigidBody;
    private ParticleSystem _jumpEffect;

    [SerializeField] private float _jumpVelocity = 4f;
    [SerializeField] private float _speed = 0.5f;

    [Header("Game settings")]
    public GameManager GameManager; 

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _jumpEffect = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        transform.position += Vector3.right * _speed * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            _rigidBody.velocity = Vector2.up * _jumpVelocity;

            // Adding particle jump & sound effects
            _jumpEffect.Play();
            JumpSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();

        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        GameManager.GameOver();
        Destroy(gameObject);
    }
}
