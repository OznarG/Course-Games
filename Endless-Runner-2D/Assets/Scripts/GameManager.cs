using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        StopScrolling();
        StopObstavles();
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
}
