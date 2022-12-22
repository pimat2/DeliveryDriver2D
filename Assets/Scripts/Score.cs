using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //public TMP_Text scoreText;
    public float currentScore;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
    // Update is called once per frame
    void Update()
    {
        // scoreText.text = currentScore.ToString("0");
    }
}
