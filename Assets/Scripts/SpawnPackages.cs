using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPackages : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Package;
    public GameObject Node;
    public GameObject[] Nodes;
    public bool hasInstantiated = false;
    public GameObject TargetIndicator;
    void Awake()
    {
       Nodes = GameObject.FindGameObjectsWithTag("Node"); 
       InstantiatePackage();
       DontDestroyOnLoad(this.gameObject);
    }
   public void InstantiatePackage()
   {
         if(hasInstantiated == false){
            int randomIndex = Random.Range(0, Nodes.Length);
            GameObject Node = Nodes[randomIndex];
            Instantiate(Package,Node.transform.position, Quaternion.identity);
            hasInstantiated = true;
            TargetIndicator.GetComponent<TargetIndicator>().StartLookingForPackage();
        }
   }
   private void Update() {
      if(Input.GetKey("escape")){
         Application.Quit();
      }
   }
    

}
