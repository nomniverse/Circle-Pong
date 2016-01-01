using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public float speed = 2.0f;

    public string creator;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Paddle")
        {
            Debug.Log("Paddle");

            if (collider.gameObject.name != creator)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.Log("Boom?");
            Destroy(gameObject);
        }
    }
}
