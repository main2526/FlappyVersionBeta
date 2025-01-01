using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private  GameObject pipePrefab; 
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 1.04f;
    [SerializeField] private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject newPipe;
        newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        Destroy(newPipe,  15f);
    }

}
