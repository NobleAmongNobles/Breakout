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
        if(gameObject.tag == "Deathzone1" && collided.tag == "Ball1"){
            RespawnBall(other.GetComponent<Ball>());
        }
        if(gameObject.tag == "Deathzone2" && collided.tag == "Ball2"){
            RespawnBall(other.GetComponent<Ball>());
        }
        if(collided.tag != "Ball1" && collided.tag != "Ball2"){
            Destroy(collided);
        }
    }

    private void RespawnBall(Ball ball){
        if(ball.gameObject.tag == "Ball1"){
            if(BallManager.instance.balls1.Count <= 1){
                ScoreManager.instance.RemoveLive(1);
            }
        }
        else{
             if(BallManager.instance.balls2.Count <= 1){
                ScoreManager.instance.RemoveLive(2);
            }   
        }

        if(ScoreManager.instance.leben1 > 0 && ScoreManager.instance.leben2 > 0){
            if(ball.gameObject.tag == "Ball1"){
                BallManager.instance.balls1.Remove(ball.gameObject);
                Destroy(ball.gameObject);
                if(BallManager.instance.balls1.Count == 0){
                    BallManager.instance.Spawnball("Paddle1");
                }
            }
            else{
                BallManager.instance.balls2.Remove(ball.gameObject);
                Destroy(ball.gameObject);
                if(BallManager.instance.balls2.Count == 0){
                    BallManager.instance.Spawnball("Paddle2");
                }
            }
        }
        else{
            SceneManager.LoadScene(3);
        }
    }
}