using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour {

    public GUISkin theSkin;
    public KeyCode space;

    private void Update()
    {
        if (Input.GetKey(space))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    private void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 175, 200, 400, 500), "THE YEAR IS 2762. ALL OF EARTH'S NATURAL RESOURCES ARE NEARLY EXPENDED. AS HUMANITY'S LAST HOPE, CAPTAIN MARTIN AND HIS CREW BEGIN SEARCHING FOR ANOTHER HABITABLE PLANET IN THE GALAXY. JUST AS THE CREW STUMBLES UPON A HABITABLE PLANET (WHAT SEEMS LIKE A MIRACLE!), THEY ARE SUDDENLY PULLED IN BY A ROGUE BLACK HOLE. REALIZING THAT HIS CREW IS HUMANITY'S LAST CHANCE AT SURVIVAL, CAPTAIN MARTIN JUMPS INTO A ROCKET POD AND LAUNCHES HIMSELF INTO THE BLACK HOLE. CAUSING THE MAIN SHIP TO BE FREED FROM THE BLACK HOLE'S GRAVITATIONAL PULL DUE TO NEWTON'S 3RD LAW, CAPTAIN MARTIN FALLS INTO DESPAIR. AND SO BEGINS HIS FINAL HOUR..");
        GUI.Label(new Rect(Screen.width / 2 - 90, 450, 400, 150), "PRESS SPACE TO CONTINUE");
    }
}
