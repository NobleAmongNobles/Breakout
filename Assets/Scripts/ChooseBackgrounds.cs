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
    public void ChooseBackground0()
    {
        background = 0;
    }
    public void ChooseBackground1()
    {
        background = 1;
    }
    public void ChooseBackground2()
    {
        background = 2;
    }
    public void ChooseBackground3()
    {
        background = 3;
    }
    public void ChooseBackground4()
    {
        background = 4;
    }
}
