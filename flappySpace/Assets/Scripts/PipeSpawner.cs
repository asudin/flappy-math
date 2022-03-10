using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Pipe Spawner Settings")]
    [SerializeField] private float _spawnTime = 8.5f;
    [SerializeField, Range(1, 10)] private float _spawnHeight = 2;

    private float _timer = 0;
    private float _score = Score._score;

    public GameObject pipe;
    
    void Update()
    {
        SpawnPipe();
        IncreasedDifficulty();
    }

    // Spawning new pipe walls with minor differences in height position each time
    void SpawnPipe()
    {
        if (_timer > _spawnTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-_spawnHeight, _spawnHeight), 0);

            Destroy(newpipe, 16);

            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    // Decreases pipe spawn timer for increased difficulty with more score
    void IncreasedDifficulty()
    {
        if (_score > 50)
        {
            _spawnTime = 7f;
        }
        else if (_score > 110)
        {
            _spawnTime = 6f;
        }
        else if (_score > 160)
        {
            _spawnTime = 7f;
        }
        else if (_score > 220)
        {
            _spawnTime = 5f;
        }
    }
}
