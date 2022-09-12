using System;
using System.Collections;
using System.Collections.Generic;
[Serializable]
public class HighscoreElement 
{   
   public string name;
   public int point;

    public HighscoreElement(string name, int points){
    this.name = name;
    this.point = points;
    } 

    override public string ToString(){
        return name + "    " + point.ToString();  
    }
}
