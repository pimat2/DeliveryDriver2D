using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomers : MonoBehaviour
{
   public GameObject Customer;
    public GameObject CustomerNode;
    public GameObject[] CustomerNodes;
    public bool hasCustomer = false;

    public GameObject TargetIndicator;
    void Start()
    {
       CustomerNodes = GameObject.FindGameObjectsWithTag("CustomerNode"); 
       DontDestroyOnLoad(this.gameObject);
    }
   public void InstantiateCustomer()
   {
         if(hasCustomer == false){
            int randomIndex = Random.Range(0, CustomerNodes.Length);
            GameObject CustomerNode = CustomerNodes[randomIndex];
            Instantiate(Customer,CustomerNode.transform.position, Quaternion.identity);
            hasCustomer = true;
            TargetIndicator.GetComponent<TargetIndicator>().StartLookingForCustomer();
        }
   }
}
