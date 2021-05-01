using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    public GameObject camera_main;
    public GameObject camera_court;
    public bool which_cam = false;

    private void Update()
    {
        if (Input.GetKeyUp("r"))
        {
            if (which_cam == false)
            {
                which_cam = true;
            }
            else if(which_cam == true)
            {
                which_cam = false;
            }
        }
        //-------------
        if (which_cam == false)
        {
            camera_main.active = true;
            camera_court.active = false;
        }
        if (which_cam == true)
        {
            camera_main.active = false;
            camera_court.active = true;
        }

    }
}
