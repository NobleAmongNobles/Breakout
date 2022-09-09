using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Paddle : MonoBehaviour
{   public static Paddle instance;
    public float speed = 7f;
    public Vector2 size;
    public int player;

    private float input;

    void Awake(){
      if(gameObject.tag == "Paddle1"){
        player = 1;
      }
      else{
        player = 2;
      }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 pos = transform.position;
      if(player == 1){
        if (Input.GetKey("left")){
          pos.x -= speed * Time.deltaTime;
        }
         
        if (Input.GetKey("right")){
          pos.x += speed * Time.deltaTime;
        }
      }
      if(player == 2){
        if (Input.GetKey(KeyCode.A)){
          pos.x -= speed * Time.deltaTime;
        }
         
        if (Input.GetKey(KeyCode.D)){
          pos.x += speed * Time.deltaTime;
        }
      }
      transform.position = pos;
    }

    private void FixedUpdate(){
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * input;
    }

    void OnTriggerEnter2D (Collider2D other)
    { 
      GameObject collided = other.gameObject;

      switch(collided.tag){
        case "Item1":
          StartCoroutine(Resize());
          break;
        case "Speedboost":
          StartCoroutine(Speedup()); 
          break;
        case "Scoremodifier":
          StartCoroutine(Scoremultiply()); 
          break;
        case "BallspeedDecrease":
          StartCoroutine(BallspeedDecrease());
          break;
        case "ExtraLife":
          ScoreManager.instance.AddLive(player); 
          break;
        case "Multiball":
          BallManager.instance.Spawnball(gameObject.tag);
          break;
        case "MinusScore":
          ScoreManager.instance.RemovePoints(20, player);
          break;
        case "SlowDown":
          StartCoroutine(Slowdown());
          break;
        case "Speedball":
          StartCoroutine(Speedball());
          break;
      }
      
      if (collided.tag != "Ball1" || collided.tag != "Ball2"){
        Destroy(collided);
      }
    }
    IEnumerator Speedup (){
        speed *= 2f;
        yield return new WaitForSeconds(10);
        speed /= 2f;
    }

    IEnumerator Resize (){
       size = transform.localScale;
       size.y *= 1.5f;
       transform.localScale = size;
       yield return new WaitForSeconds(10);
       size = transform.localScale;
       size.y /= 1.5f;
       transform.localScale = size; 
    }

    IEnumerator Scoremultiply (){
      if(player == 1)
      {
        BrickManager.instance.pointsBrick1Player1 *= 2;
        BrickManager.instance.pointsBrick2Player1 *= 2;
        BrickManager.instance.pointsBrick3Player1 *= 2;
        BrickManager.instance.pointsBrick4Player1 *= 2;
        yield return new WaitForSeconds(10);
        BrickManager.instance.pointsBrick1Player1 /= 2;
        BrickManager.instance.pointsBrick2Player1 /= 2;
        BrickManager.instance.pointsBrick3Player1 /= 2;
        BrickManager.instance.pointsBrick4Player1 /= 2;
      }
      else{
        BrickManager.instance.pointsBrick1Player2 *= 2;
        BrickManager.instance.pointsBrick2Player2 *= 2;
        BrickManager.instance.pointsBrick3Player2 *= 2;
        BrickManager.instance.pointsBrick4Player2 *= 2;
        yield return new WaitForSeconds(10);
        BrickManager.instance.pointsBrick1Player2 /= 2;
        BrickManager.instance.pointsBrick2Player2 /= 2;
        BrickManager.instance.pointsBrick3Player2 /= 2;
        BrickManager.instance.pointsBrick4Player2 /= 2;
      }
    }

    IEnumerator BallspeedDecrease (){
      if(player == 1){
        foreach(GameObject ball in BallManager.instance.balls1){
          ball.GetComponent<Ball>().speed /=2f;
        }
        yield return new WaitForSeconds(10);
        foreach(GameObject ball in BallManager.instance.balls1){
          ball.GetComponent<Ball>().speed *= 2f;
        }
      }
      else{
        foreach(GameObject ball in BallManager.instance.balls2){
          ball.GetComponent<Ball>().speed /=2f;
        } 
        yield return new WaitForSeconds(10);
        foreach(GameObject ball in BallManager.instance.balls2){
          ball.GetComponent<Ball>().speed *= 2f;
        }
      }
    }
    
    IEnumerator Slowdown(){
        speed /= 1.5f;
        yield return new WaitForSeconds(3);
        speed *= 1.5f; 
    }

    IEnumerator Speedball(){
        if(player == 1){
        foreach(GameObject ball in BallManager.instance.balls1){
          ball.GetComponent<Ball>().speed *=1.5f;
        }
        yield return new WaitForSeconds(3);
        foreach(GameObject ball in BallManager.instance.balls1){
          ball.GetComponent<Ball>().speed /= 1.5f;
        }
      }
      else{
        foreach(GameObject ball in BallManager.instance.balls2){
          ball.GetComponent<Ball>().speed *=1.5f;
        } 
        yield return new WaitForSeconds(3);
        foreach(GameObject ball in BallManager.instance.balls2){
          ball.GetComponent<Ball>().speed /= 1.5f;
        }
      }
    }
}
