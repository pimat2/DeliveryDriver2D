using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    private Transform Target;
    public float HideDistance;
    
    private Transform Customer;
    public void StartLookingForPackage() {
        Target = GameObject.FindWithTag("Package").transform;
    }
    public void StartLookingForCustomer(){
        Target = GameObject.FindWithTag("Customer").transform;
    }
    private void Update() 
    {
        if(Target != null){
            var dir = Target.position - transform.position;
        if(dir.magnitude < HideDistance){
            SetChildrenActive(false);
        }
        else{
             SetChildrenActive(true);
        }
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        if(Customer != null){
            var dir = Customer.position - transform.position;
            if(dir.magnitude < HideDistance){
                SetChildrenActive(false);
            }
            else{
                SetChildrenActive(true);
            }
            var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
    }
    void SetChildrenActive(bool value){
        foreach(Transform child in transform){
            // if(child.tag == "Arrow"){
            //     child.gameObject.SetActive(value);
            // }
            // else if(child.tag == "Triangle"){
            //     child.gameObject.SetActive(value);
            // }
            child.gameObject.SetActive(value);
        }
    }
}
