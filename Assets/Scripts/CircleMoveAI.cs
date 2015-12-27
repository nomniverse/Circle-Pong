using UnityEngine;
using System.Collections;

public class CircleMoveAI : MonoBehaviour {

    public Transform center;
    public float degreesPerSecond = -65.0f;

    public Vector3 v, entityPosition, playerDirection, rotation;

    public float deadzone = 0.001f;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //v = transform.position - center.position;
        //if ()
        //{
        //    MoveClockwise();
        //}
        //else if ()
        //{
        //    MoveAntiClockwise();
        //}
        
        //RotateObject();

        v = transform.position - center.position;
        if (Input.GetAxis("Horizontal 2") > (0.0 + deadzone) || Input.GetAxis("Vertical 2") > (0.0 + deadzone))
        {
            MoveClockwise();
        }
        else if (Input.GetAxis("Horizontal 2") < (0.0 - deadzone) || Input.GetAxis("Vertical 2") < (0.0 - deadzone))
        {
            MoveAntiClockwise();
        }
        else { }

        RotateObject();
    }

    public void RotateObject()
    {
        playerDirection = center.position - transform.position;
        rotation = new Vector3(0, 0, Mathf.Atan2(playerDirection.y, playerDirection.x));
        GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(rotation * Mathf.Rad2Deg);
    }

    public void MoveClockwise()
    {
        v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.forward) * v;
        transform.position = center.position + v;
    }

    public void MoveAntiClockwise()
    {
        v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.back) * v;
        transform.position = center.position + v;
    }
}
