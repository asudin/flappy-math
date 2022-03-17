using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    public float _speed = 0.5f;

    private float _score = Score._score;

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        IncreasedSpeed();
    }

    // Incrases pipe moving speed towards player for increased difficulty
    void IncreasedSpeed()
    {
        if (gameObject == GameObject.FindGameObjectWithTag("pipewalls"))
        {
            if (_score > 10)
            {
                _speed = 1f;
            }
            else if (_score > 80)
            {
                _speed = 1.2f;
            }
            else if (_score > 110)
            {
                _speed = 0.8f;
            }
            else if (_score > 160)
            {
                _speed = 1.5f;
            }
            else if (_score > 220)
            {
                _speed = 1.8f;
            }
        }
    }
}
