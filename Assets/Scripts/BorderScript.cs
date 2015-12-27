using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class BorderScript : MonoBehaviour {

    public GameObject playerPaddle, aiPaddle;

    public Text p1Score, p2Score;

    private int score1, score2;

    // Use this for initialization
    void Start () {
        score1 = Int32.Parse(p1Score.text);
        score2 = Int32.Parse(p2Score.text);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            BallMove ballScript = collider.gameObject.GetComponent<BallMove>();

            if (ballScript.hasNoOneTouched())
            {
                ResetPaddles();
            }
            else
            {
                if (ballScript.hasPlayerLastTouched())
                {
                    score1++;
                    p1Score.text = score1.ToString();
                }
                else
                {
                    score2++;
                    p2Score.text = score2.ToString();
                }
            }

            ballScript.ResetBall();
        }
    }

    void ResetPaddles()
    {
        playerPaddle.transform.position = new Vector3(-4.5f, 0, 0);
        aiPaddle.transform.position = new Vector3(4.5f, 0, 0);
    }
}
