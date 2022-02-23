using UnityEngine;

public class RingsSpinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    //private float timer;
    //private float timePassed = 8f;
    //private float duration = 5f;
    //private float startTime;

    public SpriteRenderer sprite;

    private void Awake()
    {
        rotationSpeed = Random.Range(1, 16);
        //startTime = Time.time;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
        //Transparency();
    }

    //void Transparency()
    //{
    //    if (timer > timePassed)
    //    {
    //        float t = (Time.time - startTime) / duration;
    //        sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(0.08f, 0.54f, t));

    //        timer = 0;
    //    }
    //    timer += Time.deltaTime;
    //}
}
