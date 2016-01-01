using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width / 2) - (225 / 2), ((Screen.height / 2) + 60), 225, 60), "START"))
        {
            SceneManager.LoadScene("main");
        }
    }
}
