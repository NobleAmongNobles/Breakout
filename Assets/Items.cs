using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{    
    protected int speed = 3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
      transform.Translate(Vector2.down * Time.deltaTime * speed, 0);
    }
    // Update is called once per frame
   
}
