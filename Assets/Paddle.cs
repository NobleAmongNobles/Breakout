using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Paddle : MonoBehaviour
{   public static Paddle instance;
    public float speed = 7f;
     public Vector2 size;

    private float input;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate(){
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * input;
    }
    void OnTriggerEnter2D (Collider2D other)
    { 
        GameObject collided = other.gameObject;
      if(collided.tag == "Item1")
      {
       StartCoroutine(Resize());
      
      }
      if(collided.tag == "Speedboost"){
        StartCoroutine(Speedup());
       
      }
      if(collided.tag == "Scoremodifier"){
        StartCoroutine(Scoremultiply());
        
      }
      if (collided.tag == "Ballspeeddecrease"){
        StartCoroutine(Ballspeeddecrease());
       
      }
      if(collided.tag == "ExtraLife"){
        ScoreManager.instance.AddLive();
        
      }
      if(collided.tag == "Multiball"){
        Ballmanager.instance.Spawnball();
        
      }
      if (collided.tag == "MinusScore"){
        ScoreManager.instance.RemovePoints(20);
        
      }
      if(collided.tag == "SlowDown"){
        StartCoroutine(Slowdown());
      }
      if(collided.tag == "Speedball"){
        StartCoroutine(Speedball());
      }
      if (collided.tag != "Ball"){
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
        BrickManager.instance.points *= 2;
        yield return new WaitForSeconds(10);
        BrickManager.instance.points /= 2;
    }
    IEnumerator Ballspeeddecrease (){
        Ball.instance.speed /= 2f; 
        yield return new WaitForSeconds(10);
        Ball.instance.speed *= 2f; 
    }
    IEnumerator Slowdown(){
        speed /= 1.5f;
        yield return new WaitForSeconds(3);
        speed *= 1.5f; 
    }
    IEnumerator Speedball(){
        Ball.instance.speed *= 1.5f; 
        yield return new WaitForSeconds(3);
        Ball.instance.speed /= 1.5f; 
    }

   
}
