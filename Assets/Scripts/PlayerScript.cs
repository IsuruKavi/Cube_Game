using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float horizontalInput;
    private float xrange = 7.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        horizontalInput = Input.touchCount;
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x <-xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        
        
        transform.Translate(Vector3.right*speed*Time.deltaTime*horizontalInput);
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
