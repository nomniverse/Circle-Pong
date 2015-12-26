using UnityEngine;
using System.Collections;

public class CircleMovePlayer : CircleMoveAI {
    
    public float deadzone = 0.001f;

	// Use this for initialization
	void Start () {
        v = transform.position - center.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Horizontal") > (0.0 + deadzone) || Input.GetAxis("Vertical") > (0.0 + deadzone))
        {
            v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.forward) * v;
            transform.position = center.position + v;
        }
        else if (Input.GetAxis("Horizontal") < (0.0 - deadzone) || Input.GetAxis("Vertical") < (0.0 - deadzone))
        {
            v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.back) * v;
            transform.position = center.position + v;
        }
        else {}

        RotateObject();
    }
}
