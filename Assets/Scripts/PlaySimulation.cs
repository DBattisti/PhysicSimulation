using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySimulation : MonoBehaviour {

    public LeverController refLeverContoller;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        refLeverContoller.isSimulating = true;
    }
}
