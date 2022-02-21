using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Pipe Spawner Settings")]
    public float spawnTime = 8;
    private float timer = 0;
    public GameObject pipe;
    public float spawnHeight;
    private float score = Score.score;

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

            Destroy(newpipe, 6);

            timer = 0;
        }

        timer += Time.deltaTime;

        switch (spawnTime)
        {
            case 50:
                spawnTime = 7;
                break;

            case 110:
                spawnTime = 6;
                break;

            case 160:
                spawnTime = 7;
                break;

            case 220:
                spawnTime = 5;
                break;

            default:
                spawnTime = spawnTime;
                break;
        }

    }
}