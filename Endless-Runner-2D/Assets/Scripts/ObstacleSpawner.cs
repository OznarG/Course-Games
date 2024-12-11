using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstacles;

    public float minSpawnTime, maxSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        float waitTime = 1f;
    }
    void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[random], transform.position, Quaternion.identity);
    }
}
