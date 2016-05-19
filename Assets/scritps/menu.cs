using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

    public string playLevel;

    public void startGame()
    {
        Application.LoadLevel(playLevel);
    }

    public void quit()
    {
        Application.Quit;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
