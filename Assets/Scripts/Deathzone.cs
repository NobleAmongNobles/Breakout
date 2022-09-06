using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
        GameObject collided = other.gameObject;
        if(collided.tag == "Ball"){
            if(Ballmanager.instance.balls.Count <= 1){
                ScoreManager.instance.RemoveLive();
            }
            else{
                Destroy(collided);
                Ballmanager.instance.balls.Remove(collided);
            }
            if(ScoreManager.instance.leben>0){
                other.GetComponent<Ball>().Respawn();
            }else{
            SceneManager.LoadScene(2);
            }
        }
        
        if(collided.tag == "Item1"){
            Destroy(collided);
        }
        
        
        
    }
}
