using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMove : MonoBehaviour {

    public float snake_speed;
    public float rotate_speed;
    public List<GameObject> snake_tail = new List<GameObject>();
    public float z_offset = 0.5f;
    public GameObject tail_prefab;

    public Text score_info;
    public int score_game = 0;

	void Start () {
        snake_tail.Add(gameObject);
	}
	
	void Update ()
    {
        score_info.text = score_game.ToString();
        transform.Translate(Vector3.forward * snake_speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime);//rotate right after @D@
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * rotate_speed * Time.deltaTime);//rotate left after @A@
        }
        //------------------------
        //if (score_game >= 10)
        //{
        //    //tail_prefab;
        //    GameObject.Find("Ground");
        //    Renderer rendus = GameObject.Find("Ground").GetComponent<Renderer>();
        //    Color change = Color.green;
        //    rendus.material.color = change;
        //}
        //----------------------
    }

    public void AddSnakeTail()
    {
        score_game++;
        Vector3 NewTailPos = snake_tail[snake_tail.Count-1].transform.position;
        NewTailPos.z -= z_offset;

        snake_tail.Add(GameObject.Instantiate(tail_prefab,NewTailPos, Quaternion.identity) as GameObject);
    }
}


