using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    bool w1 = false,w2 = false, w3 = false;
    bool t1 = false, t2 = false, t3 = false;
    bool b1 = false, b2 = false, b3 = false, b4=false,b5=false;
    Rigidbody rb;
    Vector3 lastVel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVel = rb.velocity;
    }
   
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag!="plunger")
        {
            if (this.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                this.GetComponent<Rigidbody>().transform.position = new Vector3(3.109f, 0.13f, 1.42f);
                Debug.Log("Ball stop");
            }
        }
        if (other.gameObject.tag == "activeB")
        {
            //reflect ball on active bumper
            rb.velocity = Vector3.Reflect(lastVel.normalized,other.contacts[0].normal) * Mathf.Max(lastVel.magnitude, 0);
        }
        
        switch (other.gameObject.tag)
        {
            case "w1":
                if (!w1)
                {
                    ScoreManager.score += 30;
                    w1 = true;
                    StartCoroutine(delayw1());
                }
                break;
            case "w2":
                if (!w2)
                {
                    ScoreManager.score += 30;
                    w2 = true;
                    StartCoroutine(delayw2());
                }
                break;
            case "w3":
                if (!w3)
                {
                    ScoreManager.score += 30;
                    w3 = true;
                    StartCoroutine(delayw3());
                }
                break;
            case "t1":
                if (!t1)
                {
                    ScoreManager.score += 10;
                    t1 = true;
                    StartCoroutine(delayt1());
                }
                break;
            case "t2":
                if (!t2)
                {
                    ScoreManager.score += 10;
                    t2 = true;
                    StartCoroutine(delayt2());
                }
                break;
            case "t3":
                if (!t3)
                {
                    ScoreManager.score += 10;
                    t3 = true;
                    StartCoroutine(delayt3());
                }
                break;
            case "b1":
                if (!b1)
                {
                    ScoreManager.score += 20;
                    b1 = true;
                    StartCoroutine(delayb1());
                }
                break;
            case "b2":
                if (!b2)
                {
                    ScoreManager.score += 20;
                    b2 = true;
                    StartCoroutine(delayb2());
                }
                break;
            case "b3":
                if (!b3)
                {
                    ScoreManager.score += 20;
                    b3 = true;
                    StartCoroutine(delayb3());
                }
                break;
            case "b4":
                if (!b4)
                {
                    ScoreManager.score += 20;
                    b4 = true;
                    StartCoroutine(delayb4());
                }
                break;
            case "b5":
                if (!b5)
                {
                    ScoreManager.score += 20;
                    b5 = true;
                    StartCoroutine(delayb5());
                }
                break;
            default:
                break;
        }
        
    }
    //this delay for not calculating same score more than one time for one time collide.
    IEnumerator delayw1()
    {
        yield return new WaitForSeconds(4f);
        w1 = false;
    }
    IEnumerator delayw2()
    {
        yield return new WaitForSeconds(4f);
        w2 = false;
    }
    IEnumerator delayw3()
    {
        yield return new WaitForSeconds(4f);
        w3 = false;
    }
    IEnumerator delayt1()
    {
        yield return new WaitForSeconds(4f);
        t1 = false;
    }
    IEnumerator delayt2()
    {
        yield return new WaitForSeconds(4f);
        t2 = false;
    }
    IEnumerator delayt3()
    {
        yield return new WaitForSeconds(4f);
        t3 = false;
    }
    IEnumerator delayb1()
    {
        yield return new WaitForSeconds(4f);
        b1 = false;
    }
    IEnumerator delayb2()
    {
        yield return new WaitForSeconds(4f);
        b2 = false;
    }
    IEnumerator delayb3()
    {
        yield return new WaitForSeconds(4f);
        b3 = false;
    }
    IEnumerator delayb4()
    {
        yield return new WaitForSeconds(4f);
        b4 = false;
    }
    IEnumerator delayb5()
    {
        yield return new WaitForSeconds(4f);
        b5 = false;
    }
   
}
