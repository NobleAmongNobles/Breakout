using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmanager : MonoBehaviour
{   public static Ballmanager instance;
    public GameObject Ball;
    public List<GameObject> balls = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        ResetLevel(1);
    }
    private void Awake(){
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetLevel(int mod){
        foreach (GameObject ball in balls)
        {
            Destroy(ball);
        }
        balls.Clear();
        if (mod == 1){
        GameObject ball = Instantiate(Ball, Vector2.zero, Quaternion.identity);
        balls.Add(ball);
        }
    }
    public void Spawnball(){
        GameObject ball = Instantiate(Ball, Vector2.zero, Quaternion.identity);
        balls.Add(ball);
    }
}
