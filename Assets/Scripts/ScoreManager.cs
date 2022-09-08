using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    public Text lebentext1;
    public Text lebentext2;

    int score = 0;
    int highscore = 0;
    public int leben1 = 3;
    public int leben2 = 3;

    private void Awake(){
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {    
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text =  "Punkte: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
        lebentext1.text = "Leben: " + leben1.ToString();
        lebentext2.text = "Leben: " + leben2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint(int amount){
        score += amount;
        scoreText.text =  "Punkte: " + score.ToString() ;
        if(score > highscore){
            PlayerPrefs.SetInt("highscore", score);
            highscore = score;
            highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
        }
    }
    
    public void RemovePoints(int amount){
        if(score > highscore){
            PlayerPrefs.SetInt("highscore", (score - amount));
            highscore = score - amount;
            highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
        }
        score-= amount;
        scoreText.text = "Punkte: " + score.ToString() ;
    }

    public void RemoveLive (int player){
        if(player == 1){
            leben1 -= 1;
            lebentext1.text = "Leben: " + leben1.ToString(); 
        }
        else{
            leben2 -= 1;
            lebentext2.text = "Leben: " + leben2.ToString(); 
        }
    }

    public void AddLive(int player){
        if(player == 1){
            leben1 += 1;
            lebentext1.text = "Leben: " + leben1.ToString(); 
        }
        else{
            leben2 += 1;
            lebentext2.text = "Leben: " + leben2.ToString(); 
        }
    }
}
