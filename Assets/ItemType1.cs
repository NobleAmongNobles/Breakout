using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType1 : Items
{    public static ItemType1 instance;
    // Start is called before the first frame update
    private void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }
}
