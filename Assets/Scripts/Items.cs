using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public Items instance;
    protected int speed = 3; 
    
    void Awake(){
      instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.down * Time.deltaTime * speed, 0);
    }
}
