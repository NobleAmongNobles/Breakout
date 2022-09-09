using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public Items instance;
    protected int speed = 3;
    protected string player; 
    
    void Awake()
    {
      instance = this;
      player = ItemManager.instance.playerCalled;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      if(player == "Ball1")
      {
        transform.Translate(Vector2.down * Time.deltaTime * speed, 0);
      }
      else
      {
        transform.Translate(Vector2.up * Time.deltaTime * speed, 0);
      }
      
    }
}
