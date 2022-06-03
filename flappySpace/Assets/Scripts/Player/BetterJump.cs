using UnityEngine;

public class BetterJump : MonoBehaviour
{
    Rigidbody2D RigidBody;

    [SerializeField] private float _fallMultiplier = 1.2f;
    [SerializeField] private float _lowJumpMultiplier = 2f;

    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        SmoothJump();
    }

     private void SmoothJump()
    {
        if (RigidBody.velocity.y < 0)
        {
            RigidBody.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
        }
        else if (RigidBody.velocity.y > 0 && !Input.GetMouseButtonDown(0))
        {
            RigidBody.velocity += Vector2.up * Physics2D.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
