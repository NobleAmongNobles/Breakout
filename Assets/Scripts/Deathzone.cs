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
            if(BallManager.instance.balls.Count <= 1){
                ScoreManager.instance.RemoveLive();
            }
            else{
                BallManager.instance.balls.Remove(collided);
                Destroy(collided);
            }

            if(ScoreManager.instance.leben>0){
                other.GetComponent<Ball>().Respawn();
            }
            else{
                SceneManager.LoadScene(2);
            }
        }
        else{
            Destroy(collided);
        }
    }
}
