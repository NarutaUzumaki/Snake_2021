using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDie : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
                Application.LoadLevel(Application.loadedLevel);
        }
    }
}
