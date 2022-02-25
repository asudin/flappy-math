using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [Header("Object Spawner Settings")]
    [SerializeField] private float spawnTime = 6.5f;
    [SerializeField, Range(1,20)] private float spawnHeight = 14f;

    private float speed;
    private float timer = 0f;

    public GameObject obj;

    // spawns new pipe walls with minor differences in height position each time
    void Update()
    {
        speed = Random.Range(0.6f, 1f);

        if (timer > spawnTime)
        {
            GameObject newobj = Instantiate(obj);
            newobj.transform.position = transform.position + new Vector3(10, Random.Range(-spawnHeight, spawnHeight), Random.Range(50, 60));

            transform.position += Vector3.left * speed * Time.deltaTime;

            Destroy(newobj, 60);

            timer = 0;

            spawnTime = 30;
        }

        timer += Time.deltaTime;
    }
}
