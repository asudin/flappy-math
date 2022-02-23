using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    public float speed = 0.5f;

    private float score = Score.score;

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        switch (score)
        {
            case 40:
                speed = 1f;
                break;

            case 80:
                speed = 1.2f;
                break;

            case 110:
                speed = 0.8f;
                break;

            case 160:
                speed = 1.5f;
                break;

            case 220:
                speed = 1.8f;
                break;

            default:
                speed = 0.5f;
                break;
        }
    }
}
