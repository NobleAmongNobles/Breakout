using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallManager : MonoBehaviour
{   public static BallManager instance;
    public GameObject ball1;
    public GameObject ball2;
    public List<GameObject> balls1 = new List<GameObject>();
    public List<GameObject> balls2 = new List<GameObject>();
    public int mode;

    private void Awake(){
        instance = this;
        mode = SceneManager.GetActiveScene().buildIndex;
        ResetLevel();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel(){
        foreach (GameObject ball in balls1)
        {
            Destroy(ball);
        }
         foreach (GameObject ball in balls2)
        {
            Destroy(ball);
        }
        balls2.Clear();
        if (mode == 1){
            GameObject ball = Instantiate(ball1, Vector2.zero, Quaternion.identity);
            balls1.Add(ball);
        }
        else{
            GameObject ball = Instantiate(ball1, Vector2.zero, Quaternion.identity);//position
            balls1.Add(ball);
            ball = Instantiate(ball2, Vector2.zero, Quaternion.identity);//position
            balls2.Add(ball); 
        }

    }

    public void Spawnball(string player){
        if(mode == 1){
            GameObject ball = Instantiate(ball1, Vector2.zero, Quaternion.identity);
            balls1.Add(ball);
        }
        else{
            if(player == "Paddle1"){
                GameObject ball = Instantiate(ball1, Vector2.zero, Quaternion.identity);//position
                balls1.Add(ball);
            }
            else{
                GameObject ball = Instantiate(ball2, Vector2.zero, Quaternion.identity);//position
                balls2.Add(ball);
            }
        }
    }
}
