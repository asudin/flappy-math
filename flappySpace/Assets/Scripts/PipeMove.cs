using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    [SerializeField, Range(1, 10)] private float speed = 1f;

    private float score = Score.score;

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        switch (score)
        {
            case 40:
                speed = 1.5f;
                break;

            case 80:
                speed = 1.8f;
                break;

            case 110:
                speed = 1.1f;
                break;

            case 160:
                speed = 2.2f;
                break;

            case 220:
                speed = 2.5f;
                break;

            default:
                speed = speed;
                break;
        }
    }
}
