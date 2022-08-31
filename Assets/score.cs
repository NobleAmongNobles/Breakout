using system.Collections;
using system.Collections.generic;
using UnityEngine;
using UnityEnging.UI;

public class Scoremanager : Monobehavior{

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text ="Highscore: " + highscore.ToString();
    } 
}