using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   public static MainMenu instance;
    public bool singleplayer = true;
    public bool endless = false;

    void Awake(){
        instance = this;
    }
    public void PlayGame(){
        if(singleplayer){
            SceneManager.LoadScene(1);
        }
        else{
            SceneManager.LoadScene(2);
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
}
