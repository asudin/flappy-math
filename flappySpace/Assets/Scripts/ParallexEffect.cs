using UnityEngine;

public class ParallexEffect : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;
    [SerializeField] private float parallexEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float temporaryPosition = (cam.transform.position.x * (1 - parallexEffect));
        float distance = (cam.transform.position.x * parallexEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (temporaryPosition > startPos + length)
        {
            startPos += length;
        }
        else if (temporaryPosition < startPos + length)
        {
            startPos -= length;
        }
    }
}
