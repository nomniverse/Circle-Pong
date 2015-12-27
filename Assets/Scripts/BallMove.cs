using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    public float speed = 2.0f;

    public GameObject center;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ResetBall()
    {
        transform.position = center.transform.position;
        
        if (Random.Range(0,2) == 0)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        } else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
    }
}
