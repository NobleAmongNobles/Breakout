using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBackgrounds : MonoBehaviour
{   
    public static ChooseBackgrounds instance;
    public GameObject[] DefaultBackground;

    void Awake(){
        instance = this;
    }
    void Start(){
        switch(PlayerPrefs.GetInt("Background",0)){
            case 0:
                DefaultBackground[0].SetActive(true);
                DefaultBackground[1].SetActive(false);
                DefaultBackground[2].SetActive(false);
                DefaultBackground[3].SetActive(false);
                DefaultBackground[4].SetActive(false);
                break;
            case 1:
                DefaultBackground[0].SetActive(false);
                DefaultBackground[1].SetActive(true);
                DefaultBackground[2].SetActive(false);
                DefaultBackground[3].SetActive(false);
                DefaultBackground[4].SetActive(false);
                break;
            case 2:
                DefaultBackground[0].SetActive(false);
                DefaultBackground[1].SetActive(false);
                DefaultBackground[2].SetActive(true);
                DefaultBackground[3].SetActive(false);
                DefaultBackground[4].SetActive(false);
                break;
            case 3:
                DefaultBackground[0].SetActive(false);
                DefaultBackground[1].SetActive(false);
                DefaultBackground[2].SetActive(false);
                DefaultBackground[3].SetActive(true);
                DefaultBackground[4].SetActive(false);
                break;
            case 4:
                DefaultBackground[0].SetActive(false);
                DefaultBackground[1].SetActive(false);
                DefaultBackground[2].SetActive(false);
                DefaultBackground[3].SetActive(false);
                DefaultBackground[4].SetActive(true);
                break;
        }
    }
    public void ChooseBackground(int choice)
    {
        PlayerPrefs.SetInt("Background",choice);
    }
}
