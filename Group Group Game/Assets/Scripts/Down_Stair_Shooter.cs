using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Stair_Shooter: MonoBehaviour
{ 
    public GameObject stair_segment_down;
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Instantiate(stair_segment_down, this.transform.position, this.transform.rotation);
        }
    }
}
