using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemManager : MonoBehaviour
{   
    public static ItemManager instance;
    public GameObject ItemType1;
    public GameObject ItemType2;
    public GameObject ItemType3;
    public GameObject ItemType4;
    public GameObject ItemType5;
    public GameObject ItemType6;
    public GameObject ItemType7;
    public GameObject ItemType8;
    public GameObject ItemType9;
    public string playerCalled;
    private List<GameObject> items = new List<GameObject>();

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void CallforItems (Vector2 startvector, string player)  {
        System.Random itemgenerator = new System.Random();
        int randomnumber = itemgenerator.Next(0, 200);
        playerCalled = player;
        if (randomnumber >= 50 && randomnumber < 60)
        {
            GameObject item = Instantiate(ItemType2, startvector, Quaternion.identity);
        }
        if (randomnumber >= 60 && randomnumber < 70)
        {
            GameObject item = Instantiate(ItemType1, startvector, Quaternion.identity);
        }
        if (randomnumber >= 70 && randomnumber < 80){
            GameObject item = Instantiate(ItemType3, startvector, Quaternion.identity);
        }
        if (randomnumber >= 80 && randomnumber < 90){
            GameObject item = Instantiate(ItemType4, startvector, Quaternion.identity); 
        }
        if(randomnumber >= 90 && randomnumber < 100){
            GameObject item = Instantiate(ItemType5, startvector, Quaternion.identity); 
        }
        if(randomnumber >= 100 && randomnumber < 110){
            GameObject item = Instantiate(ItemType6, startvector, Quaternion.identity); 
        }
        if(randomnumber >= 110 && randomnumber < 120){
            GameObject item = Instantiate(ItemType7, startvector, Quaternion.identity); 
        }
        if(randomnumber >= 120 && randomnumber < 130){
            GameObject item = Instantiate(ItemType8, startvector, Quaternion.identity); 
        }
        if(randomnumber >= 130 && randomnumber < 140){
            GameObject item = Instantiate(ItemType9, startvector, Quaternion.identity); 
        }
    }
}
