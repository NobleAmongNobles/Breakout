using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText1;
    public Text scoreText2;
    public Text highscoreText;
    public Text lebentext1;
    public Text lebentext2;

    int score1 = 0;
    int score2 = 0;
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
        scoreText1.text =  "Punkte: " + score1.ToString();
        scoreText2.text =  "Punkte: " + score2.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString() + " Punkte";
        lebentext1.text = "Leben: " + leben1.ToString();
        lebentext2.text = "Leben: " + leben2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint(int amount, string player){
        if(player == "Ball1"){
            score1 += amount;
            scoreText1.text =  "Punkte: " + score1.ToString() ;
            if(score1 > highscore){
                PlayerPrefs.SetInt("highscore", score1);
                highscore = score1;
                highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
            }
        }
        else{
            score2 += amount;
            scoreText2.text =  "Punkte: " + score2.ToString() ;
            if(score2 > highscore){
                PlayerPrefs.SetInt("highscore", score2);
                highscore = score2;
                highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
            }
        }
    }
    
    public void RemovePoints(int amount, int player){
        if(player == 1){
            if(score1 > highscore){
                PlayerPrefs.SetInt("highscore", (score1 - amount));
                highscore = score1 - amount;
                highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
            }
            score1 -= amount;
            scoreText1.text = "Punkte: " + score1.ToString();
        }
        else{
            if(score2 > highscore){
                PlayerPrefs.SetInt("highscore", (score2 - amount));
                highscore = score2 - amount;
                highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
            }
            score2-= amount;
            scoreText2.text = "Punkte: " + score2.ToString();
        }
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
