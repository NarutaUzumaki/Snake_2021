using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseManip : MonoBehaviour {
	private bool paused = false;
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if (!paused) {
				Time.timeScale = 0;
				paused = true;
			} else {
				Time.timeScale = 1;
				paused = false;
            }
		}
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
	}
}
