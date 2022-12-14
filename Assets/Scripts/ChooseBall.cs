using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBall : MonoBehaviour
{   public static ChooseBall instance;
    public Button[] buttonsPlayer1;
    public Button[] buttonsPlayer2;
    public GameObject[] imagesPlayer1;
    public GameObject[] imagesPlayer2;
    public GameObject[] disabled1;
    public GameObject[] disabled2;

    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start(){
        buttonsPlayer1[PlayerPrefs.GetInt("BallPlayer1",0)].onClick.Invoke();
        buttonsPlayer2[PlayerPrefs.GetInt("BallPlayer2",0)].onClick.Invoke();
    }

    public void ClickPlayer1(int choice){
        SetBall(choice, 1);
        LockButtons();
        MarkButton(choice, 1);
        ShowChoiceDisable(choice, 1);
    }

    public void ClickPlayer2(int choice){
        SetBall(choice, 2);
        LockButtons();
        MarkButton(choice, 2);
        ShowChoiceDisable(choice, 2);
    }

    private void SetBall(int choice, int player){
        if(player == 1){
            PlayerPrefs.SetInt("BallPlayer1",choice);
        }
        if(player == 2){
            PlayerPrefs.SetInt("BallPlayer2",choice);
        }
    }

    private void MarkButton(int choice, int player){
        if(player == 1){
            foreach(GameObject image in imagesPlayer1){
                image.SetActive(false);
            }
            imagesPlayer1[choice].SetActive(true);
        }
        if(player == 2){
            foreach(GameObject image in imagesPlayer2){
                image.SetActive(false);
            }
            imagesPlayer2[choice].SetActive(true);
        }
    }

    private void LockButtons(){
        foreach(Button button in buttonsPlayer1){
            button.interactable = true;
        }
        foreach(Button button in buttonsPlayer2){
            button.interactable = true;
        }
        buttonsPlayer1[PlayerPrefs.GetInt("BallPlayer1",0)].interactable = false;
        buttonsPlayer2[PlayerPrefs.GetInt("BallPlayer2",0)].interactable = false;

        if(PlayerPrefs.GetInt("BallPlayer2",0) != 0){
            buttonsPlayer1[PlayerPrefs.GetInt("BallPlayer2",0)].interactable = false;
        }
        if(PlayerPrefs.GetInt("BallPlayer1",0) != 0){
            buttonsPlayer2[PlayerPrefs.GetInt("BallPlayer1",0)].interactable = false;
        }
    }

    private void ShowChoiceDisable(int choice, int player){
        if(player == 1){
            foreach(GameObject Disable in disabled2){
                Disable.gameObject.SetActive(false);
            }
            if(choice != 0){
                disabled2[choice].gameObject.SetActive(true);
            }
        }
        if(player == 2){
            foreach(GameObject Disable in disabled1){
                Disable.gameObject.SetActive(false);
            }
            if(choice != 0){
                disabled1[choice].gameObject.SetActive(true);
            }
        }
    }
}
