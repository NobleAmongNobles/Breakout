using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBall : MonoBehaviour
{   public static ChooseBall instance;
    public int? ballPlayer1;
    public int? ballPlayer2;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    
    public void Player1 (int choice){
        ballPlayer1 = choice;
    }

    public void Player2 (int choice){
        ballPlayer1 = choice;
    }

    
    
}
