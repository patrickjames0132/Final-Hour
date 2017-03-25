using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public GUISkin theSkin;
    public Camera mainCam;
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;

    // Use this for initialization
    void Start()
    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
    }

    void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width - 300, 20, 500, 500), string.Format("{0:mm}:{0:ss}:{0:ff}", System.DateTime.Parse(System.TimeSpan.FromSeconds(Time.timeSinceLevelLoad).ToString())));
    }
}