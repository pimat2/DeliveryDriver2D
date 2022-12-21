using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 1f;
    [SerializeField] float boostSpeed = 30f;
    void Start()
    {
        Debug.Log("Hello I am driver");
        
    }
    void OnCollisionEnter2D(Collision2D other) {
            moveSpeed = slowSpeed;
            
        }
    void OnCollisionExit2D(Collision2D other) {
        StartCoroutine(FadeSlow());
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SpeedBump"){
                moveSpeed = boostSpeed;
            }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "SpeedBump"){
                
                StartCoroutine(FadeBoost());
            }
    }
    void Update()
    {
        
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
        
    }
    IEnumerator FadeBoost(){
        yield return new WaitForSeconds(0.5f);
        moveSpeed = 10f;
    }
    IEnumerator FadeSlow(){
        yield return new WaitForSeconds(0.5f);
        moveSpeed = 10f;
    }
    
}
