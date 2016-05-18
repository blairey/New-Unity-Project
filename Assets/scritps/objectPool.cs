using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class objectPool : MonoBehaviour
{

    public GameObject poolObject;

    public int poolSize;

    List<GameObject> poolObjects;



    // Use this for initialization
    void Start()
    {

        poolObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject Object = (GameObject)Instantiate(poolObject);
            Object.SetActive(false);
            poolObjects.Add(Object);
        }
    }

    public GameObject GetPoolObj()
    {
        for(int i = 0; i < poolObjects.Count;i++)
        {
            if(!poolObjects[i].activeInHierarchy)
            {
                return poolObjects[i];
            }
        }

        GameObject Object = (GameObject)Instantiate(poolObject);
        Object.SetActive(false);
        poolObjects.Add(Object);

        return Object;

    }
}


