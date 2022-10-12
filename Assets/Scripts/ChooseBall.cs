using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBall : MonoBehaviour
{   public static ChooseBall instance;
    public Button[] SelectedDefaultPlayer1;
    public Button[] SelectedDefaultPlayer2;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start(){
        SelectedDefaultPlayer1[PlayerPrefs.GetInt("BallPlayer1",0)].onClick.Invoke();
        SelectedDefaultPlayer2[PlayerPrefs.GetInt("BallPlayer2",0)].onClick.Invoke();
    }
    
    public void Player1 (int choice){
        PlayerPrefs.SetInt("BallPlayer1",choice);
    }

    public void Player2 (int choice){
        PlayerPrefs.SetInt("BallPlayer2",choice);
    }

    
    
}
