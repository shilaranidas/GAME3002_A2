using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//for kicking the ball
public class PlungerScript : MonoBehaviour
{
    float power;
    public float minPower = 0f;
    public float maxPower = 100f;
    public Slider powerSlider;
    //handling all balls during the play
    List<Rigidbody> ballList;
    bool ballReady;
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<Rigidbody>();  
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
    }

    // Update is called once per frame
    void Update()
    {
        //check for ball is near the plunger or not
        if (ballReady)
            powerSlider.gameObject.SetActive(true);
        else
            powerSlider.gameObject.SetActive(false);
        powerSlider.value = power;
        if (ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (power <= maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballList)
                {
                    r.AddForce(power * Vector3.forward);
                }
            }
        }
        else
        { 
            ballReady = false;
            power = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0f;
        }
    }
}
