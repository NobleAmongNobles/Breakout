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

    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start(){
        buttonsPlayer1[PlayerPrefs.GetInt("BallPlayer1",0)].onClick.Invoke();
        buttonsPlayer2[PlayerPrefs.GetInt("BallPlayer2",0)].onClick.Invoke();
    }

    public void ClickPlayer1(int choice){
        LockButtonForOtherPlayer(choice, 1);
        SetBall(choice, 1);
        MarkButton(choice, 1);
        MakeButtonsInteractable(choice, 1);
    }

    public void ClickPlayer2(int choice){
        LockButtonForOtherPlayer(choice, 2);
        SetBall(choice, 2);
        MarkButton(choice, 2);
        MakeButtonsInteractable(choice, 2);
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

    private void LockButtonForOtherPlayer(int choice, int player){
        if(player == 1){
            foreach(Button button in buttonsPlayer2){
                button.gameObject.SetActive(true);
            }
            if(choice != 0){
                buttonsPlayer2[choice].gameObject.SetActive(false);
            }
        }
        if(player == 2){
            foreach(Button button in buttonsPlayer1){
                button.gameObject.SetActive(true);
            }
            if(choice != 0){
                buttonsPlayer1[choice].gameObject.SetActive(false);
            }
        }
    }

    private void MakeButtonsInteractable(int choice, int player){
        if(player == 1){
            foreach(Button button in buttonsPlayer1){
                button.interactable = true;
            }
            buttonsPlayer1[choice].interactable = false;
        }
        if(player == 2){
            foreach(Button button in buttonsPlayer2){
                button.interactable = true;
            }
            buttonsPlayer2[choice].interactable = false;
        }
    }
}
