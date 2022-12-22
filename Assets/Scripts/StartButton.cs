using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Tutorial");
   }
   public void Continue(){
    SceneManager.LoadScene("FirstLevel");
   }
   public void Back(){
    SceneManager.LoadScene("StartingScene");
   }
   public void GoToSecondLevel(){
    SceneManager.LoadScene("SecondLevel");
   }
   public void GoToThirdLevel(){
    SceneManager.LoadScene("ThirdLevel");
   }
}
