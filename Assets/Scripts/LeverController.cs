using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour {

    public Vector2 loadPosition;
    public Vector2 effortPosition;
    public Vector2 loadForce;
    public Vector2 effortForce;

    public GameObject loadIcon;
    public GameObject effortIcon;

    private Rigidbody2D leverRB;
    public bool isSimulating;

    // Use this for initialization
    void Start () {
        leverRB = GetComponentInChildren<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isSimulating)
        {
            leverRB.AddForceAtPosition(loadForce, loadIcon.transform.position);
            leverRB.AddForceAtPosition(effortForce, effortIcon.transform.position);
        }
    }

    float CalcTorque(float force, float distance) {
        return force * distance;
    }

}
