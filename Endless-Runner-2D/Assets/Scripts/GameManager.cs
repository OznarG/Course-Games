using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject obstacleSpawner;
    public GameObject gameOverPanel;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        StopScrolling();
        StopObstavles();

        obstacleSpawner.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsByType<TextureScroll>(FindObjectsSortMode.None);
        foreach(TextureScroll obj in scrollingObjects)
        {
            obj.scroll = false;
        }
    }

    void StopObstavles()
    {
        GameObject[] obsacles = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach(GameObject o in obsacles)
        {
            if(o != null)
            {
                o.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
