using UnityEngine;
using System.Collections;

public class PlatfromDestroyer : MonoBehaviour {

    public GameObject platformDestruction;

	// Use this for initialization
	void Start () {

        platformDestruction = GameObject.Find("PlatformDestroyer");
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < platformDestruction.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
	
	}
}
