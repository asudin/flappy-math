using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    [SerializeField, Range(1, 10)] private float speed = 2f;

    private float score = Score.score;

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        switch (score)
        {
            case 40:
                speed = 2.5f;
                break;

            case 80:
                speed = 2.8f;
                break;

            case 110:
                speed = 2;
                break;

            case 160:
                speed = 3.2f;
                break;

            case 220:
                speed = 4;
                break;

            default:
                speed = speed;
                break;
        }
    }
}
