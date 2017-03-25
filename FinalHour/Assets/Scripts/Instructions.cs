using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

    public GUISkin theSkin;

    private void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 500, 100, 1200, 300), "OBJECTIVE:\n\n1. DON'T GET HIT BY ASTEROIDS\n\n2. DON'T FALL INTO THE BLACK HOLE\n\n3. DON'T RUN OUT OF FUEL");
        GUI.Label(new Rect(Screen.width / 2 - 500, 375, 1000, 300), "CONTROLS:\n\nPRESS SPACE TO THRUST UPWARDS");

        if (GUI.Button(new Rect(Screen.width / 2 - 75, 500, 150, 100), "BACK"))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}
