using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText1;
    public Text scoreText2;
    public Text highscoreText;
    public Text lebentext1;
    public Text lebentext2;

    public int score1 = 0;
    public int score2 = 0;
    public int highscore;
    public int leben1 = 3;
    public int leben2 = 3;
    public  List<HighscoreElement> highscores = new List<HighscoreElement>();

    private void Awake(){
        instance = this;
        highscore = PlayerPrefs.GetInt("highscore1",0);
    }
    
    // Start is called before the first frame update
    void Start()
    {    
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name1",""), PlayerPrefs.GetInt("highscore1", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name2",""),PlayerPrefs.GetInt("highscore2", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name3",""),PlayerPrefs.GetInt("highscore3", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name4",""),PlayerPrefs.GetInt("highscore4", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name5",""),PlayerPrefs.GetInt("highscore5", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name6",""),PlayerPrefs.GetInt("highscore6", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name7",""),PlayerPrefs.GetInt("highscore7", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name8",""),PlayerPrefs.GetInt("highscore8", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name9",""),PlayerPrefs.GetInt("highscore9", 0)));
        highscores.Add(new HighscoreElement(PlayerPrefs.GetString("Name10",""),PlayerPrefs.GetInt("highscore10", 0)));
        


        highscore = PlayerPrefs.GetInt("highscore1", 0);
        scoreText1.text =  "Punkte: " + score1.ToString();
        scoreText2.text =  "Punkte: " + score2.ToString();
        highscoreText.text = "Highscore: " + highscore + " Punkte";
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
                highscore = score1;
                highscoreText.text = "Highscore: " + highscore.ToString() + " Punkte";
            }
        }
        else{
            score2 += amount;
            scoreText2.text =  "Punkte: " + score2.ToString() ;
            if(score2 > highscore){
                highscore = score2;
                highscoreText.text = "Highscore: " + highscore.ToString() + " Punkte";
            }
        }
    }
    public void NewHighscore(HighscoreElement highscore) {
        // Adds a new score to the leaderboard
        highscores.Add(highscore);
        // Sorts the leaderboard by value
        ScoreManager.instance.SortbyPoints(highscores);
        highscores.Reverse();

        // Saves the first ten values
        while(highscores.Count() >= 11){
            highscores.RemoveAt(highscores.Count() - 1);
        }
        PlayerPrefs.SetInt("highscore1", highscores.ElementAt(0).point);
        PlayerPrefs.SetInt("highscore2", highscores.ElementAt(1).point);
        PlayerPrefs.SetInt("highscore3", highscores.ElementAt(2).point);
        PlayerPrefs.SetInt("highscore4", highscores.ElementAt(3).point);
        PlayerPrefs.SetInt("highscore5", highscores.ElementAt(4).point);
        PlayerPrefs.SetInt("highscore6", highscores.ElementAt(5).point);
        PlayerPrefs.SetInt("highscore7", highscores.ElementAt(6).point);
        PlayerPrefs.SetInt("highscore8", highscores.ElementAt(7).point);
        PlayerPrefs.SetInt("highscore9", highscores.ElementAt(8).point);
        PlayerPrefs.SetInt("highscore10",highscores.ElementAt(9).point);
 
        PlayerPrefs.SetString("Name1", highscores.ElementAt(0).name);
        PlayerPrefs.SetString("Name2", highscores.ElementAt(1).name);
        PlayerPrefs.SetString("Name3", highscores.ElementAt(2).name);
        PlayerPrefs.SetString("Name4", highscores.ElementAt(3).name);
        PlayerPrefs.SetString("Name5", highscores.ElementAt(4).name);
        PlayerPrefs.SetString("Name6", highscores.ElementAt(5).name);
        PlayerPrefs.SetString("Name7", highscores.ElementAt(6).name);
        PlayerPrefs.SetString("Name8", highscores.ElementAt(7).name);
        PlayerPrefs.SetString("Name9", highscores.ElementAt(8).name);
        PlayerPrefs.SetString("Name10", highscores.ElementAt(9).name);

    }
    public List<HighscoreElement> SortbyPoints(List<HighscoreElement> List){
        HighscoreElement temp;
        for (int i = 0; i < List.Count; i++)
        {
            for (int j = 0; j < List.Count - 1; j++)
            {
                if (List[j].point > List[j + 1].point)
                {
                    temp = List[j + 1];
                    List[j + 1] = List[j];
                    List[j] = temp;
                }
            }
        }
        return List;
    }
    public void RemovePoints(int amount, int player){
        if(player == 1){
            if(score1 > highscore){
                highscore= score1 - amount;
                highscoreText.text = "Highscore: " + highscore.ToString() + "Punkte";
            }
            score1 -= amount;
            scoreText1.text = "Punkte: " + score1.ToString();
        }
        else{
            if(score2 > highscores[0].point){
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
