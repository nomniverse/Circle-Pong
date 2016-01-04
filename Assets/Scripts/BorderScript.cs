using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class BorderScript : MonoBehaviour {
    
    public GameObject[] paddles;

    public Text p1Score, p2Score;

    private int score1, score2;

    public int winner;

    // Use this for initialization
    void Start () {
        score1 = Int32.Parse(p1Score.text);
        score2 = Int32.Parse(p2Score.text);

        paddles = GameObject.FindGameObjectsWithTag("Paddle");
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

                if (score1 >= 21 && (score1 - score2) >= 2)
                {
                    winner = 1;
                }
                else if (score2 >= 21 && (score2 - score1) >= 2)
                {
                    winner = 2;
                }
            }

            ballScript.ResetBall();
        }
    }

    void ResetPaddles()
    {
        foreach (GameObject paddle in paddles)
        {
            paddle.GetComponent<CircleMove>().ResetPaddle();
        }
    }
}
