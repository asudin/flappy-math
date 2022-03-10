using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _jumpVelocity = 4f;
    [SerializeField] private float _speed = 0.5f;

    private Rigidbody2D rb;

    //public GameObject effect;
    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }

    // Game over screen when player outside of screen boundaries
    void OnBecameInvisible()
    {
        //GameManager.GameOver();
    }
}
