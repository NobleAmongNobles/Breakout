using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{   public static AudioManager instance;
    AudioSource[] backgroundMusic;
    AudioClip Mariomusic;
    AudioClip Synthwave;

    void Awake(){
        instance = this;
        backgroundMusic = GetComponents<AudioSource>();
        switch(Backgrounds.instance.background){
            case 0:
                backgroundMusic[0].Play(0);
                break;
            case 1: 
                backgroundMusic[1].Play(0);
                break; 
            case 2: 
                backgroundMusic[2].Play(0);
                break;
            case 3: 
                backgroundMusic[3].Play(0);
                break;
            case 4:
                backgroundMusic[4].Play();
                break;
       }
    }

    public AudioSource GetBGM(){
        return backgroundMusic[Backgrounds.instance.background];
    }
}
