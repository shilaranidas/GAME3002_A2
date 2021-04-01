using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public float explosionStrength = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //it introduce a bounciness when collide with ball
    private void OnCollisionEnter(Collision other)
    {
        other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
    }
}
