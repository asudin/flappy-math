using UnityEngine;

public class ParallexEffect : MonoBehaviour
{
    [SerializeField] private float parallexEffect;
    private float _length, _startPos;

    public GameObject cam;

    void Start()
    {
        _startPos = transform.position.x;
        _length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Creates background as the player moves through space
    void FixedUpdate()
    {
        float temporaryPosition = (cam.transform.position.x * (1 - parallexEffect));
        float distance = (cam.transform.position.x * parallexEffect);

        transform.position = new Vector3(_startPos + distance, transform.position.y, transform.position.z);

        if (temporaryPosition > _startPos + _length)
        {
            _startPos += _length;
        }
        else if (temporaryPosition < _startPos + _length)
        {
            _startPos -= _length;
        }
    }
}
