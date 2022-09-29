using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{   public static MainMenu instance;
    public AudioMixer mixer;
    public float mastervolume;
    public bool singleplayer = true;
    public bool endless = false;

    void Awake(){
        instance = this;
    }

    void Start()
    {
        SetVolumeLevel(0.5f);
    }

    public void PlayGame(){
        Ball.additionalSpeed = 1;
        Paddle.additionalSpeed = 1;
        if(singleplayer){
            SceneManager.LoadScene(1);
        }
        else{
            SceneManager.LoadScene(4);
        }
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ToggleMultiplayer(){
        singleplayer = !singleplayer;
    }
    
    public void Endless(){
        endless = true;
        PlayGame();
    }

    public void ShowControls(){
        SceneManager.LoadScene(7);
    }

    public void SetVolumeLevel (float sliderValue){
        mixer.SetFloat("MasterVolume",Mathf.Log10(sliderValue)*20);
        mastervolume = Mathf.Log10(sliderValue)*20;
    }
}
