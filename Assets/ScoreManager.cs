using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    public Text lebentext;

    int score = 0;
    int highscore = 0;
    public int leben = 3;
    // Start is called before the first frame update
    private void Awake(){
        instance = this;
    }
    void Start()
    {    highscore = PlayerPrefs.GetInt("highscore", 0);
         scoreText.text = score.ToString() + "Punkte: ";
         highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
         lebentext.text = "Leben: " + leben.ToString();
    }
    public void AddPoint(int amount){
        score += amount;
        scoreText.text = score.ToString() + "Punkte: ";
        if(score > highscore){
            PlayerPrefs.SetInt("highscore", score);
            highscore = score;
            highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
        }
    }
    public void RemoveLive (){
        leben -= 1;
        lebentext.text = "Leben: " + leben.ToString();
        if (leben == 0){

        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
