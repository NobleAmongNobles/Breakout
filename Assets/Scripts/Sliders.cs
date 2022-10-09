using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake(){
        Slider m = gameObject.GetComponent<Slider>();
        if (gameObject.tag == "MusicVolume"){
            m.value = PlayerPrefs.GetFloat("MusicVolume",0.5f);
        }
        if (gameObject.tag == "SoundeffectVolume"){
            m.value = PlayerPrefs.GetFloat("SoundeffectVolume",0.5f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
