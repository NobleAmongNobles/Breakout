using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : Items
{    public static Speedboost instance;

    private void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }
}
