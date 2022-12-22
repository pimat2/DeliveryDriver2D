using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject ScoreObject;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreObject = GameObject.FindWithTag("ScoreKeeper");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreObject.GetComponent<Score>().currentScore.ToString();
    }
}
