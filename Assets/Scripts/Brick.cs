using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{  public Brick instance;
public void Awake(){
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
        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick1);
        ItemManager.instance.CallforItems(transform.position);
        Destroy(gameObject);
    }
}
