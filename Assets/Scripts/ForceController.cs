using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceController : MonoBehaviour
{


    public float speedMouse;
    public Transform Fulcrum;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        float prevXPosition = transform.localPosition.x;
        float newXPosition = Mathf.Clamp(prevXPosition + (Input.GetAxis("Mouse X") * speedMouse), -1, Fulcrum.position.x);

        transform.localPosition = new Vector3(newXPosition, 0.3f);
    }
}
