using UnityEngine;
using System.Collections;

public class GottaGoFast : MonoBehaviour {

    public float speedBoost = 1.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            collider.gameObject.GetComponent<Rigidbody2D>().velocity *= speedBoost;
        }
    }
}
