using UnityEngine;
using System.Collections;

public class CircleMoveAI : MonoBehaviour {

    public Transform center;
    public float degreesPerSecond = -65.0f;

    public Vector3 v, entityPosition, playerDirection, rotation;

    // Use this for initialization
    void Start () {
        v = transform.position - center.position;
	}
	
	// Update is called once per frame
	void Update () {
        v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.forward) * v;
        transform.position = center.position + v;

        RotateObject();
    }

    public void RotateObject()
    {
        playerDirection = center.position - transform.position;
        rotation = new Vector3(0, 0, Mathf.Atan2(playerDirection.y, playerDirection.x));
        GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(rotation * Mathf.Rad2Deg);
    }
}
