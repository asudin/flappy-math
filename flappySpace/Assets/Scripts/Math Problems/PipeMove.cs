using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    public float Speed = 0.5f;

    private float _score = Score._score;

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
        IncreasedSpeed();
    }

    // Incrases pipe moving speed towards player for increased difficulty
    private void IncreasedSpeed()
    {
        if (gameObject == GameObject.FindGameObjectWithTag("pipewalls"))
        {
            if (_score > 10)
            {
                Speed = 1f;
            }
            else if (_score > 80)
            {
                Speed = 1.2f;
            }
            else if (_score > 110)
            {
                Speed = 0.8f;
            }
            else if (_score > 160)
            {
                Speed = 1.5f;
            }
            else if (_score > 220)
            {
                Speed = 1.8f;
            }
        }
    }
}
