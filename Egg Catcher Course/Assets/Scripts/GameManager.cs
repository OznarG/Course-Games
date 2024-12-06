using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject egg;
    public Transform spawnPoint;
    Vector3 spawnPosition;
    bool gameOver = false;

    public float spawnSpeed = 1.0f;

    public float maxPos;
    int score = 0;

    public TextMeshProUGUI scoreText;
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
        float randomX = Random.Range(-maxPos, maxPos);
        spawnPosition.x = randomX;
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

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        print(score);
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
