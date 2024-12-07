using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    public GameObject startUI;
    public GameObject gameOverUI;
    public GameObject basket;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = spawnPoint.position;
        //StartCoroutine("SpawnEggs");
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
        startUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
        basket.SetActive(true);
        StartCoroutine("SpawnEggs");
    }

    public void GameOver()
    {
        StopCoroutine("SpawnEggs");
        gameOverUI.SetActive(true);
        scoreText.gameObject.SetActive(false);
        basket.SetActive(false);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
