using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //public TMP_Text scoreText;
    public float currentScore;
    private Scene scene;
    public GameObject destroyObject;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);

        
    }
    // Update is called once per frame
    void Update()
    {
        if(scene.name == "FirstLevel" && currentScore >= 50f){
            destroyObject.GetComponent<Restart>().DestroyPersistentObject();
            SceneManager.LoadScene("SecondLevelExplanation");
        }
        if(scene.name == "SecondLevel" && currentScore >=50f){
            destroyObject.GetComponent<Restart>().DestroyPersistentObject();
            SceneManager.LoadScene("ThirdLevelExplanation");
        }
    }
}
