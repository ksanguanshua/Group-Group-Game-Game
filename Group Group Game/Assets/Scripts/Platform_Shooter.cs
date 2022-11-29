using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Shooter : MonoBehaviour
{
    public GameObject stair_segment_up;
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(stair_segment_up, this.transform.position, this.transform.rotation);
        }
    }
}
