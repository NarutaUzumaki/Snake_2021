using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public float score;
    public SnakeMove test;

    private void Start()
    {
        test = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();
        score = test.score_game;
        if(score >= 1)
        {
            GameObject.Find("Ground");
            Renderer rendus = GameObject.Find("Ground").GetComponent<Renderer>();
            Color change = Color.green;
            rendus.material.color = change;
        }
    }
    //score.gameobject.GetComponent<SnakeMove>()
    //void Awake()
    //{
    //    if (score_game >= 5)
    //    {
    //        //tail_prefab;
    //        main_snake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();
    //        Renderer rendus = tail_prefab.GetComponent<Renderer>();
    //        Color change = Color.green;
    //        rendus.material.color = change;
    //    }
    //}


    
}
