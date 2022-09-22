using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{   public AudioMixer mixer;
    public float mastervolume;
    public static VolumeManager instance;
    void Awake(){
        instance = this;
    }
    public void SetLevel (float sliderValue){
        mixer.SetFloat("MasterVolume",Mathf.Log10(sliderValue)*20);
        mastervolume = Mathf.Log10(sliderValue)*20;
    }
}
