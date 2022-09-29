using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public static Ball instance;
    public float speed = 6f;
    public static float additionalSpeed = 1;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private void Awake(){
        instance = this;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        if(gameObject.tag == "Ball1"){
            try{
                spriteRenderer.sprite = spriteArray[(int)ChooseBall.instance.ballPlayer1];
            }
            catch{
                spriteRenderer.sprite = spriteArray[0];
            }           
        }
        if(gameObject.tag == "Ball2"){
           try{
                spriteRenderer.sprite = spriteArray[(int)ChooseBall.instance.ballPlayer2];
            }
            catch{
                spriteRenderer.sprite = spriteArray[0];
            } 
        }
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * (speed + additionalSpeed);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = (speed + additionalSpeed) * (GetComponent<Rigidbody2D>().velocity.normalized);
        float ratio = GetComponent<Rigidbody2D>().velocity.x / GetComponent<Rigidbody2D>().velocity.y;
        if(ratio > 40 || ratio < -40){
            if(GetComponent<Rigidbody2D>().velocity.y > 0){
                GetComponent<Rigidbody2D>().velocity += new Vector2(0, 0.7f);
            }
            else{
                if (gameObject.tag == "Ball1"){
                    GetComponent<Rigidbody2D>().velocity -= new Vector2(0, 0.7f);
                }
                if (gameObject.tag == "Ball2" && GetComponent<Rigidbody2D>().velocity.y == 0){
                    GetComponent<Rigidbody2D>().velocity += new Vector2(0, 0.7f);
                }
            }
        }
        if(ratio < 0.001f && -0.001 < ratio){
            if(GetComponent<Rigidbody2D>().velocity.x > 0){
                GetComponent<Rigidbody2D>().velocity += new Vector2(0.7f, 0);
            }
            else{
                GetComponent<Rigidbody2D>().velocity -= new Vector2(0.7f, 0);
            }
        }
    }
}
