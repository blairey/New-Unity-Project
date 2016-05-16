using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public AlanController alan;

    private Vector3 alanPosition;

    private float cameraMovement;

	// Use this for initialization
	void Start () {

        alan = FindObjectOfType<AlanController>();

        alanPosition = alan.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        cameraMovement = alan.transform.position.x - alanPosition.x;

        transform.position = new Vector3(transform.position.x + cameraMovement, transform.position.y, transform.position.z);

        alanPosition = alan.transform.position;
	
	}
}
