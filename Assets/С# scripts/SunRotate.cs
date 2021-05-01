using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{

    public float speed;
    private Vector3 Axis = new Vector3(1, 0, 0); //ось x
    Light _light;

    void Start()
    {
        _light = GetComponent<Light>();
    }
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Axis);  //получаем кватернион и совершаем поворот
    }
}