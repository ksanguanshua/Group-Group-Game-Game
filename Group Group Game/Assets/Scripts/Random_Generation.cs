using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Generation : MonoBehaviour
{

    public GameObject[] myObjects;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            

            Instantiate(myObjects[randomIndex], new Vector3(14,-2), Quaternion.identity);
        }
    }
}