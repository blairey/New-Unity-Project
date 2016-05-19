using UnityEngine;
using System.Collections;

public class countertopGene : MonoBehaviour {

    //public GameObject [] Platform;
    public GameObject [] Platforms;
    public Transform platformGenePoint;
    public float distance;

    private int PlatformChoice;
 
    private int PlatformChooser;
    private float [] widthOfPlatform;

    public objectPool [] ObjectPool;


    public float platformDistanceMinimum;
    public float PlatformDistanceMaximum;

    private float minimumPlatformHeight;
    public Transform maximumPlatformHeightRange;
    private float maximumPlatformHeight;
    public float maximumHeightDifference;
    private float heightDifference;


	// Use this for initialization
	void Start () {

        widthOfPlatform = new float [ObjectPool.Length]; 

        for (int i = 0; i < ObjectPool.Length; i++)
        {
            widthOfPlatform[i] = ObjectPool[i].poolObject.GetComponent<BoxCollider2D>().size.x;
        }
        minimumPlatformHeight = transform.position.y;
        minimumPlatformHeight = maximumPlatformHeightRange.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < platformGenePoint.position.x)
        {
            distance = Random.Range(platformDistanceMinimum, PlatformDistanceMaximum);
            PlatformChooser = Random.Range(0, ObjectPool.Length);


            heightDifference = transform.position.y + Random.Range(maximumHeightDifference, -maximumHeightDifference);

            if(heightDifference > maximumPlatformHeight)
            {
                heightDifference = maximumPlatformHeight;
            }
            else if(heightDifference < minimumPlatformHeight)
            {
                heightDifference = minimumPlatformHeight;
            }

            transform.position = new Vector3(transform.position.x + (widthOfPlatform[PlatformChooser] / 2) + distance , heightDifference , transform.position.z);

           // Instantiate(Platforms[PlatformChooser], transform.position, transform.rotation);
            
            GameObject newCountertop = ObjectPool[PlatformChooser].GetPoolObj();

            newCountertop.transform.position = transform.position;
            newCountertop.transform.rotation = transform.rotation;
            newCountertop.SetActive(true);

            transform.position = new Vector3(transform.position.x + (widthOfPlatform[PlatformChooser] / 2), transform.position.y, transform.position.z);
            //Instantiate (Platform, transform.position, transform.rotation);

        }
	
	}
}
