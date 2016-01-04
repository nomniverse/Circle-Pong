using UnityEngine;
using System.Collections;

public class CircleMove : MonoBehaviour {

    public Transform center;

    public float degreesPerSecond = -100.0f;

    private Vector3 v, playerDirection, rotation, originalPosition;

    public float deadzone = 0.001f;

    public int playerNumber;

    private string playerHorizontalControl;

    // Use this for initialization
    void Start () {
        originalPosition = transform.position;
        playerHorizontalControl = "Horizontal" + playerNumber;
    }
	
	// Update is called once per frame
	void Update () {
        v = transform.position - center.position;
        
        if (Input.GetAxis(playerHorizontalControl) > (0.0 + deadzone))
        {
            MoveClockwise();
        }
        else if (Input.GetAxis(playerHorizontalControl) < (0.0 - deadzone))
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

    public void ResetPaddle()
    {
        transform.position = originalPosition;
    }
}
