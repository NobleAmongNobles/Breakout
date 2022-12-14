using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickMultiHit : MonoBehaviour
{  
    public BrickMultiHit instance;
    public int hits;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    
    public void Awake(){
        switch (gameObject.tag){
            case "Brick1":
                hits = 1;
                break;
            case "Brick2":
                hits = 2;
                break;
            case "Brick3":
                hits = 3;
                break;
            case "Brick4":
                hits = 4;
                break;
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(MainMenu.instance.endless){
            Ball.additionalSpeed *= 1.01f;
            Paddle.additionalSpeed = Ball.additionalSpeed;
        }

        hits -= 1;
        string ball = other.gameObject.tag;
        if(hits == 0){
            if(ball == "Ball1"){
                switch(gameObject.tag){
                    case "Brick1": 
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick1Player1, ball);
                        break;
                    case "Brick2":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick2Player1, ball);
                        break;
                    case "Brick3":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick3Player1, ball);
                        break;
                    case "Brick4":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick4Player1, ball);
                        break;
                }
            }
            else{
               switch(gameObject.tag){
                    case "Brick1": 
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick1Player2, ball);
                        break;
                    case "Brick2":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick2Player2, ball);
                        break;
                    case "Brick3":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick3Player2, ball);
                        break;
                    case "Brick4":
                        ScoreManager.instance.AddPoint(BrickManager.instance.pointsBrick4Player2, ball);
                        break;
                } 
            }
            ItemManager.instance.CallforItems(transform.position, ball);
            if (!MainMenu.instance.endless){
                BrickManager.instance.bricks.Remove(gameObject);
                Destroy(gameObject);
                if(BrickManager.instance.bricks.Count == 0){
                    if(ScoreManager.instance.leben1 > 0){
                        ScoreManager.instance.score1 += 250;
                    }
                    if(ScoreManager.instance.leben2 > 0){
                        ScoreManager.instance.score2 += 250;
                    }
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }else{
                StartCoroutine(Respawn(gameObject));
            }
        }
        else{
            ChangeSprite();
        }
    }

    IEnumerator Respawn(GameObject gameObject){
        gameObject.GetComponent<Collider2D>().enabled = false;
        var color = gameObject.GetComponent<SpriteRenderer>().material.color;
        color.a = 0f;
        gameObject.GetComponent<SpriteRenderer>().material.color = color;
        yield return new WaitForSeconds(45);
        gameObject.GetComponent<Collider2D>().enabled = true;
        color.a = 1f;
        gameObject.GetComponent<SpriteRenderer>().material.color = color;
        switch (gameObject.tag){
            case "Brick1": 
                hits = 1;
                break;
            case "Brick2":
                hits = 2;
                break;
            case "Brick3":
                hits = 3;
                break;
            case "Brick4":
                hits = 4;
                break;   
        }
    }

    public void ChangeSprite() 
    {
        spriteRenderer.sprite = spriteArray[hits - 1];
        spriteRenderer.transform.localScale = new Vector3(1,1,1);
    }
}
