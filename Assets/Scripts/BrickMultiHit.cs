using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMultiHit : MonoBehaviour
{  
    public BrickMultiHit instance;
    public int hits;
    
    public void Awake(){
        switch (gameObject.tag){
            case "Brick1":
                hits = 1;
                break;
            case "Brick2":
                hits = 2;
                break;
            case "Brick3":
                hits = 3;
                break;
            case "Brick4":
                hits = 4;
                break;
        }
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

    private void OnCollisionEnter2D(Collision2D other){
        hits -= 1;
        if(hits == 0){
            switch(gameObject.tag){
                case "Brick1": 
                    ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick1);
                    break;
                case "Brick2":
                    ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick2);
                    break;
                case "Brick3":
                    ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick3);
                    break;
                case "Brick4":
                    ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick4);
                    break;
            }
            ItemManager.instance.CallforItems(transform.position);
            Destroy(gameObject);
        }
    }
}
