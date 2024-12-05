using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject egg;
    public Transform spawnPoint;
    Vector3 spawnPosition;
    bool gameOver = false;

    public float spawnSpeed = 1.0f;
    public int score;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = spawnPoint.position;
        StartCoroutine("SpawnEggs");
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    void SpawnEgg()
    {
        Instantiate(egg, spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnEggs()
    {
        while (true)
        {
            SpawnEgg();
            yield return new WaitForSeconds(spawnSpeed);
         
        }
    }

    public void GameStart()
    {

    }

    public void GameOver()
    {

    }

    public void Replay()
    {

    }
}
