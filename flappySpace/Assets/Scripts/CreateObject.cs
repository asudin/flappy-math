using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [Header("Object Spawner Settings")]
    [SerializeField] private float spawnTime = 4;
    [SerializeField, Range(1,20)] private float spawnHeight = 14;

    private float speed;
    private float timer = 0;

    public GameObject obj;

    // spawns new pipe walls with minor differences in height position each time
    void Update()
    {
        speed = Random.Range(0.1f, 0.6f);

        if (timer > spawnTime)
        {
            GameObject newobj = Instantiate(obj);
            newobj.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeight, spawnHeight), Random.Range(22, 50));

            transform.position += Vector3.left * speed * Time.deltaTime;

            Destroy(newobj, 60);

            timer = 0;

            spawnTime = 30;
        }

        timer += Time.deltaTime;
    }
}
