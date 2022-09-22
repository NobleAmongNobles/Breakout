using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBackgrounds : MonoBehaviour
{   
    public static ChooseBackgrounds instance;
    public int? background;

    void Awake(){
        instance = this;
    }

    public void ChooseBackground0(int bg){
        background = bg;
    }
}
