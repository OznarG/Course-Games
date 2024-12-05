using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    Vector3 touchPos;
    public float moveRate = 0.2f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 newPos = transform.position;
            newPos.x = touchPos.x;

            transform.position = newPos;
        }
    }
}
