using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,255);
    
    [SerializeField] Color32 noPackageColor = new Color32(1,0,0,255);
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Yooo man, be careful you bumped into something");
    
   }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && hasPackage == false){
            Debug.Log("And that's a trigger with the package baby");
            hasPackage = true;
            Destroy(other.gameObject, 0.5f);
            spriteRenderer.color = hasPackageColor;
            
        }
        if(other.tag == "Customer" && hasPackage == true){
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        
   }
}
