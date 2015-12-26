using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    public float speed = 2.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
