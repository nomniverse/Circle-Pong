using UnityEngine;
using System.Collections;

public class CenterMove : MonoBehaviour {

    public float speed = 0.0001f;
    public float deadzone = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speed;
        transform.position += Input.GetAxis("Vertical") * Vector3.up * Time.deltaTime * speed;
    }
}
