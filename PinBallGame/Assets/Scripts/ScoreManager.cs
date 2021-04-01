using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//for printing the score managing the score
public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreValuetxt;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreValuetxt.text = score.ToString();
    }
}
