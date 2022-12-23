using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistent : MonoBehaviour
{
    AudioSource ThemeSong;
   private void Start() {
    ThemeSong = GetComponent<AudioSource>();
    DontDestroyOnLoad(this.gameObject);
   }
   private void Update() {
     if(Input.GetKeyDown(KeyCode.M)){
        ThemeSong.mute = !ThemeSong.mute;
     }
   }
}
