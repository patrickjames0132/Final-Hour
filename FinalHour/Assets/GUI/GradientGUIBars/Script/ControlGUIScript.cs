using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGUIScript : MonoBehaviour {

    public GameObject ship;
    public float upperLimit = 100f;
    private GUIBarScript gbs;

	void Start()
	{
		gbs = GetComponent<GUIBarScript>();
    }

    void Update()
    {
        gbs.Value = (ship.GetComponent<ShipControls>().getFuel())/(upperLimit);
    }
}
