using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePaddle : MonoBehaviour
{   
    public static ChoosePaddle instance;
    public int? PaddlePlayer1;
    public int? PaddlePlayer2;
    public GameObject[] SelectedDefaultPlayer1;
    public GameObject[] SelectedDefaultPlayer2;
    // Start is called before the first frame update
    
    void Awake(){
        instance = this;
    }
    void Start(){
        switch(PlayerPrefs.GetInt("PaddlePlayer1",0)){
            case 0:
                SelectedDefaultPlayer1[0].SetActive(true);
                SelectedDefaultPlayer1[1].SetActive(false);
                SelectedDefaultPlayer1[2].SetActive(false);
                SelectedDefaultPlayer1[3].SetActive(false);
                break;
            case 1:
                SelectedDefaultPlayer1[0].SetActive(false);
                SelectedDefaultPlayer1[1].SetActive(true);
                SelectedDefaultPlayer1[2].SetActive(false);
                SelectedDefaultPlayer1[3].SetActive(false);
                break;
            case 2:
                SelectedDefaultPlayer1[0].SetActive(false);
                SelectedDefaultPlayer1[1].SetActive(false);
                SelectedDefaultPlayer1[2].SetActive(true);
                SelectedDefaultPlayer1[3].SetActive(false);
                break;
            case 3:
                SelectedDefaultPlayer1[0].SetActive(false);
                SelectedDefaultPlayer1[1].SetActive(false);
                SelectedDefaultPlayer1[2].SetActive(false);
                SelectedDefaultPlayer1[3].SetActive(true);
                break;
        }
        switch(PlayerPrefs.GetInt("PaddlePlayer2",0)){
            case 0:
                SelectedDefaultPlayer2[0].SetActive(true);
                SelectedDefaultPlayer2[1].SetActive(false);
                SelectedDefaultPlayer2[2].SetActive(false);
                SelectedDefaultPlayer2[3].SetActive(false);
                break;
            case 1:
                SelectedDefaultPlayer2[0].SetActive(false);
                SelectedDefaultPlayer2[1].SetActive(true);
                SelectedDefaultPlayer2[2].SetActive(false);
                SelectedDefaultPlayer2[3].SetActive(false);
                break;
            case 2:
                SelectedDefaultPlayer2[0].SetActive(false);
                SelectedDefaultPlayer2[1].SetActive(false);
                SelectedDefaultPlayer2[2].SetActive(true);
                SelectedDefaultPlayer2[3].SetActive(false);
                break;
            case 3:
                SelectedDefaultPlayer2[0].SetActive(false);
                SelectedDefaultPlayer2[1].SetActive(false);
                SelectedDefaultPlayer2[2].SetActive(false);
                SelectedDefaultPlayer2[3].SetActive(true);
                break;
        }

    }
    public void Player1 (int choice){
        PlayerPrefs.SetInt("PaddlePlayer1",choice);
    }

    public void Player2 (int choice){
        PlayerPrefs.SetInt("PaddlePlayer2",choice);
    }
}
