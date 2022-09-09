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
            GameObject ball = Instantiate(ball1, Vector2.zero - new Vector2(0f,0.5f), Quaternion.identity);
            balls1.Add(ball);
        }
        else{
            Vector2 spawnVector = new Vector2(0, 2.5f);
            GameObject ball = Instantiate(ball1, spawnVector * -1, Quaternion.identity);
            balls1.Add(ball);
            ball = Instantiate(ball2, spawnVector, Quaternion.identity);
            balls2.Add(ball); 
        }

    }

    public void Spawnball(string player){
        if(mode == 1){
            GameObject ball = Instantiate(ball1, Vector2.zero - new Vector2(0f,0.5f), Quaternion.identity);
            balls1.Add(ball);
        }
        else{
            Vector2 spawnVector = new Vector2(0, 2.5f);
            if(player == "Paddle1"){
                GameObject ball = Instantiate(ball1, spawnVector * -1, Quaternion.identity);
                balls1.Add(ball);
            }
            else{
                GameObject ball = Instantiate(ball2, spawnVector, Quaternion.identity);
                balls2.Add(ball);
            }
        }
    }
}
