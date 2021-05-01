using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {

    public float XWidth = 9f;
    public float ZWidth = 9f;

    public GameObject FoodPrefab;
    public Vector3 NowFoodPos;

    public GameObject ThisFood;
	
    void AddNewFood()
    {
        RandomPosition();
        ThisFood = GameObject.Instantiate(FoodPrefab, NowFoodPos, Quaternion.identity) as GameObject;
    }

    void RandomPosition()
    {
        NowFoodPos = new Vector3(Random.Range(XWidth * -1, XWidth), 0.5f, Random.Range(ZWidth * -1, ZWidth));
    }

    void Update()
    {
        if (!ThisFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
