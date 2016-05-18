using UnityEngine;
using System.Collections;

public class countertopGene : MonoBehaviour {

    public GameObject Platform;
    public Transform platformGenePoint;
    public float distance;

    private float widthOfPlatform;

    public objectPool ObjectPool;

    public float platformDistanceMinimum;
    public float PlatformDistanceMax;


	// Use this for initialization
	void Start () {

        widthOfPlatform = Platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < platformGenePoint.position.x)
        {
            distance = Random.Range(platformDistanceMinimum, PlatformDistanceMax);
            transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

            GameObject newCountertop = ObjectPool.GetPoolObj();

            newCountertop.transform.position = transform.position;
            newCountertop.transform.rotation = transform.rotation;
            newCountertop.SetActive(true);
            //Instantiate (Platform, transform.position, transform.rotation);

        }
	
	}
}
