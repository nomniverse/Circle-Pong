using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class BorderScript : MonoBehaviour {

    public Text p1Score, p2Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            int score1 = Int32.Parse(p1Score.text);
            int score2 = Int32.Parse(p2Score.text);

            score1++;
            score2++;

            p1Score.text = score1.ToString();
            p2Score.text = score2.ToString();

            collider.gameObject.GetComponent<BallMove>().ResetBall();
        }
    }
}
