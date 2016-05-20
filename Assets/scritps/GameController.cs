using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public Transform platformGene;
    private Vector3 gameBeginPoint;

    public AlanController alan;

    private Vector3 alanBeginPoint;

    private PlatfromDestroyer[] platformListing;

    public deathMenu deathMenuScreen;

	// Use this for initialization
	void Start () {

        gameBeginPoint = platformGene.position;
        alanBeginPoint = alan.transform.position;

	}
	
	// Update is called once per frame
    void Update()
    {


    }

     public void reset()
     {
         alan.gameObject.SetActive(true);

         deathMenuScreen.gameObject.SetActive(true);
       // StartCoroutine("reset");
     }

     public void resetGame()
     {
         deathMenuScreen.gameObject.SetActive(false);
         platformListing = FindObjectsOfType<PlatfromDestroyer>();
         for (int i = 0; i < platformListing.Length; i++)
         {
             platformListing[i].gameObject.SetActive(false);
         }


         alan.transform.position = alanBeginPoint;
         platformGene.position = gameBeginPoint;
         alan.gameObject.SetActive(true);
     }
  /*  public IEnumerator resetGame()
    {

        alan.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platformListing = FindObjectsOfType<PlatfromDestroyer>();
        for(int i = 0; i < platformListing.Length ; i++)
        {
            platformListing[i].gameObject.SetActive(false);
        }

        
        alan.transform.position = alanBeginPoint;
        platformGene.position = gameBeginPoint;
        alan.gameObject.SetActive(true);
    }*/
	
	
}
