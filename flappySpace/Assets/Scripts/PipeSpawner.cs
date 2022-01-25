using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Pipe Spawner Settings")]
    public float spawnTime;
    private float timer = 0;
    public GameObject pipe;
    public float spawnHeight;

    void Start()
    {
        
    }

    // spawns new pipe walls with minor differences in height position each time
    void Update()
    {
        if(timer > spawnTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeight, spawnHeight), 0);

            Destroy(newpipe, 15);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
