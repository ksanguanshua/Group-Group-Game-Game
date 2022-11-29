using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Move : MonoBehaviour
{
    public float speed = 6;


    // Start is called before the first frame update
    private void Start()
    {
        Destroy(this.gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}