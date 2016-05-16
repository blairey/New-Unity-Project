using UnityEngine;
using System.Collections;

public class countertopGene : MonoBehaviour {

    public GameObject Platform;
    public Transform platformGenePoint;
    public float distance;

    private float widthOfPlatform;


	// Use this for initialization
	void Start () {

        widthOfPlatform = Platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < platformGenePoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

            Instantiate (platformGenePoint, transform.position, transform.rotation);
        }
	
	}
}
