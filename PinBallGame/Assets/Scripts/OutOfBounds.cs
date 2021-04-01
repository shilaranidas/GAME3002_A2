using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Vector3 startingPos;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this collistion for reseting ball if they cross the out of boundary
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
           // Debug.Log("hello");
            other.rigidbody.velocity = Vector3.zero;
            other.transform.position = startingPos;
        }
    }
}
