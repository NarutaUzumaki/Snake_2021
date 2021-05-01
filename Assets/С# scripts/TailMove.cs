using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMove : MonoBehaviour
{
    public float snake_speed;
    public int index;
    public Vector3 tail_target;
    public GameObject tail_target_object;
    public SnakeMove main_snake;

    void Start ()
    {
        main_snake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();
        snake_speed = main_snake.snake_speed;
        
        tail_target_object = main_snake.snake_tail[main_snake.snake_tail.Count - 2];
        index = main_snake.snake_tail.IndexOf(gameObject);
    }
	
	void Update () {
        tail_target = tail_target_object.transform.position;
        
        transform.LookAt(tail_target);
        transform.position = Vector3.Lerp(transform.position, tail_target, Time.deltaTime * snake_speed);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (index > 2)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
