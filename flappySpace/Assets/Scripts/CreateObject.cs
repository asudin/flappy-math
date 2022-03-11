using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [Header("Object Spawner Settings")]
    [SerializeField] private float _spawnTime = 6.5f;
    [SerializeField, Range(1,20)] private float _spawnHeight = 14f;

    private float _speed;
    private float _timer = 0f;

    public GameObject spawnObject;

    // Spawning new object with height differences for aesthetics
    void Update()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        _speed = Random.Range(1f, 2f);

        if (_timer > _spawnTime)
        {
            GameObject newobj = Instantiate(spawnObject);
            newobj.transform.position = transform.position + new Vector3(10, Random.Range(-_spawnHeight, _spawnHeight), Random.Range(50, 60));

            transform.position += Vector3.left * _speed * Time.deltaTime;

            Destroy(newobj, 60);

            _timer = 0;

            _spawnTime = 30;
        }

        _timer += Time.deltaTime;
    }
}
