using UnityEngine;

public class BetterJump : MonoBehaviour
{
    [SerializeField] private float _fallMultiplier = 1.2f;
    [SerializeField] private float _lowJumpMultiplier = 2f;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        SmoothJump();
    }

    // Smoothing the player jump mechanic
    void SmoothJump()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetMouseButtonDown(0))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
