using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private BorderScript borderScript;

	// Use this for initialization
	void Start () {
        borderScript = gameObject.GetComponent<BorderScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        if (GUI.Button(new Rect((Screen.width / 2) - (225 / 2), ((Screen.height / 2) + 30), 225, 60), "PLAYER " + borderScript.winner + " WINS"))
        {
            SceneManager.LoadScene("main");
        }
    }
}
