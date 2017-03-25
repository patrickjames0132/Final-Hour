using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GUISkin theSkin;
    public GUISkin theSkin2;
    private float bestTime;

    private void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 225, 200, 1000, 75), "THE FINAL HOUR");
        if (GUI.Button(new Rect(Screen.width / 2 - 75, 275, 150, 75), "PLAY"))
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 195, 350, 400, 75), "HOW TO PLAY"))
        {
            SceneManager.LoadScene("HowToPlay", LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75, 425, 150, 75), "EXIT"))
        {
            Application.Quit();
        }
    
        GUI.skin = theSkin2;
        bestTime = PlayerPrefs.GetFloat("bestTime");
        GUI.Label(new Rect(Screen.width / 2 - 220, 525, 400, 75), "Best Time: " + bestTime);

    }
}
