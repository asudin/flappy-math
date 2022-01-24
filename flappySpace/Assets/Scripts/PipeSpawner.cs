using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnTime;
    private float timer = 0;
    public GameObject pipe;
    public float spawnHeight;

    void Start()
    {
        
    }

    // Update is called once per frame
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
