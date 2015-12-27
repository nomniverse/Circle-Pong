using UnityEngine;
using System.Collections;

public class CircleMovePlayer : CircleMoveAI {
    
    public float deadzone = 0.001f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        v = transform.position - center.position;
        if (Input.GetAxis("Horizontal 1") > (0.0 + deadzone) || Input.GetAxis("Vertical 1") > (0.0 + deadzone))
        {
            MoveClockwise();
        }
        else if (Input.GetAxis("Horizontal 1") < (0.0 - deadzone) || Input.GetAxis("Vertical 1") < (0.0 - deadzone))
        {
            MoveAntiClockwise();
        }
        else {}

        RotateObject();
    }
}
