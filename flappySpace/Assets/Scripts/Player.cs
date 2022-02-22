using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField, Range(1, 10)] private float jumpVelocity = 4f;
    [SerializeField, Range(1, 10)] private float speed = 1f;

    private Rigidbody2D rb;

    //public GameObject effect;
    public GameManager GameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Jump mechanic
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }

    // show game over screen if player is outside of screen resolution
    void OnBecameInvisible()
    {
        GameManager.GameOver();
    }
}
