using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [Header("Object Spawner Settings")]
    public GameObject SpawnObject;

    [SerializeField, Range(1,20)] private float _spawnHeight = 14f;
    [SerializeField] private float _spawnTime = 6.5f;
    private float _speed;
    private float _timer = 0f;

    void Update()
    {
        SpawningObject();
    }

    void SpawningObject()
    {
        _speed = Random.Range(1.2f, 2.2f);

        if (_timer > _spawnTime)
        {
            GameObject newobj = Instantiate(SpawnObject);
            newobj.transform.position = transform.position + new Vector3(10, Random.Range(-_spawnHeight, _spawnHeight), Random.Range(50, 60));
            transform.position += Vector3.left * _speed * Time.deltaTime;
            Destroy(newobj, 360f);
            _timer = 0;
            _spawnTime = 120f;
        }
        _timer += Time.deltaTime;
    }
}
