using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr1 : MonoBehaviour
{
    private Vector2 yon = Vector2.right;
    public Transform Snakedir;
    private List<Transform> snakeList;
    
    private void Start()
    {
        snakeList = new List<Transform>();
        snakeList.Add(this.transform);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)) { yon = Vector2.right; }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)) {yon=Vector2.left; }
        else if(Input.GetKeyDown(KeyCode.UpArrow)) { yon=Vector2.up; }  
        else if(Input.GetKeyDown(KeyCode.DownArrow)) { yon=Vector2.down; }
        

    }
    private void FixedUpdate()
    {
        for (int i = snakeList.Count - 1; i > 0; i--)
        { snakeList[i].position = snakeList[i - 1].position; }

        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + yon.x,
            Mathf.Round(this.transform.position.y) + yon.y, 0f);
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="duvar")
        {
            yon = -yon;

        }

        if (collision.tag == "food")
        {
            Transform segment = Instantiate(this.Snakedir);
            segment.position = snakeList[snakeList.Count - 1].position;
            snakeList.Add(segment);
        }
        /*
        if (collision.tag=="body")
        {
            Destroy(gameObject);
        }*/
    }
}
