using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
   public void RestartGame()
   {
     GameObject[] packageNodes = GameObject.FindGameObjectsWithTag("Node");
     foreach(GameObject packageNode in packageNodes)
     GameObject.Destroy(packageNode);
     
     GameObject[] customerNodes = GameObject.FindGameObjectsWithTag("CustomerNode");
     foreach(GameObject customerNode in customerNodes)
     GameObject.Destroy(customerNode);
     
     GameObject scoreKeeper = GameObject.FindWithTag("ScoreKeeper");
     GameObject.Destroy(scoreKeeper);
     
     GameObject[] destructables = GameObject.FindGameObjectsWithTag("forDestruction");
     foreach(GameObject destructable in destructables)
     GameObject.Destroy(destructable);
     
     SceneManager.LoadScene("ThirdLevel");
   }
}
