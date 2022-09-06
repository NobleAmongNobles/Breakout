using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Items
{    public static Item instance;
    // Start is called before the first frame update
    private void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }
}
