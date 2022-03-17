using UnityEngine;

public class RingsSpinner : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    public SpriteRenderer sprite;

    private void Awake()
    {
        _rotationSpeed = Random.Range(1, 16);
    }

    // Rotates the rings for UI aesthetics
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, _rotationSpeed) * Time.deltaTime);
    }
}
