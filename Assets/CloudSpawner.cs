using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;

    public Transform[] spawnPoints;

    public float minSpawnDelay = 2f;
    public float maxSpawnDelay = 5f;

    void Start()
    {
        Invoke(nameof(SpawnCloud), 1f);
    }

    void SpawnCloud()
    {
        int index = Random.Range(0, spawnPoints.Length);

        Instantiate(
            cloudPrefab,
            spawnPoints[index].position,
            Quaternion.identity
        );

        float delay = Random.Range(minSpawnDelay, maxSpawnDelay);

        Invoke(nameof(SpawnCloud), delay);
    }
}