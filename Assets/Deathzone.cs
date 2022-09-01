using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other){
        ScoreManager.instance.RemoveLive();
        if(ScoreManager.instance.leben>0){
        other.GetComponent<Ball>().Respawn();
        }
    }
}
