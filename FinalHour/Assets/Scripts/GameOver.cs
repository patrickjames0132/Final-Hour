using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GUISkin theSkin;
    public GUISkin theSkin2;
    private float bestTime;

    private void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150, 200, 300, 150), "GAME OVER");

        if (GUI.Button(new Rect(Screen.width / 2 - 205, 275, 400, 100), "PLAY AGAIN"))
        {
            SceneManager.LoadScene("GAME", LoadSceneMode.Single);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 80, 375, 150, 100), "MENU"))
        {
            SceneManager.LoadScene("MENU", LoadSceneMode.Single);
        }

        GUI.skin = theSkin2;
        bestTime = PlayerPrefs.GetFloat("bestTime");
        GUI.Label(new Rect(Screen.width / 2 - 158, 525, 400, 75), "Best Time: " + bestTime);
    }
}
