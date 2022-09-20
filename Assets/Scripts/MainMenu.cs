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
        Ball.additionalSpeed = 1;
        Paddle.additionalSpeed = 1;
        if(singleplayer){
            SceneManager.LoadScene(2);
        }
        else{
            SceneManager.LoadScene(5);
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
        SceneManager.LoadScene(1);
    }
}
