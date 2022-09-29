using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePaddle : MonoBehaviour
{   
    public static ChoosePaddle instance;
    public int? PaddlePlayer1;
    public int? PaddlePlayer2;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    public void Player1 (int choice){
        PaddlePlayer1 = choice;
    }

    public void Player2 (int choice){
        PaddlePlayer2 = choice;
    }
}
