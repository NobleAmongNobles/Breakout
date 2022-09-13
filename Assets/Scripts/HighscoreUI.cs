using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class HighscoreUI : MonoBehaviour
{   
    public Text highscoreText1;
	public Text highscoreText2;
	public Text highscoreText3;
    public Text highscoreText4;
	public Text highscoreText5;
	public Text highscoreText6;
    public Text highscoreText7;
	public Text highscoreText8;
	public Text highscoreText9;
    public Text highscoreText10;
	
    void Awake(){
        highscoreText1.text = "1.	" + PlayerPrefs.GetString("Name1") + "  " + PlayerPrefs.GetInt("highscore1",0).ToString();
		highscoreText2.text = "2.	" + PlayerPrefs.GetString("Name2") + "  " + PlayerPrefs.GetInt("highscore2",0).ToString();
		highscoreText3.text = "3.	" +  PlayerPrefs.GetString("Name3") + "  " + PlayerPrefs.GetInt("highscore3",0).ToString();
        highscoreText4.text = "4.	" +  PlayerPrefs.GetString("Name4") + "  " + PlayerPrefs.GetInt("highscore4",0).ToString();
        highscoreText5.text = "5.	" +  PlayerPrefs.GetString("Name5") + "  " +  PlayerPrefs.GetInt("highscore5",0).ToString();
        highscoreText6.text = "6.	" +  PlayerPrefs.GetString("Name6") + "  " +  PlayerPrefs.GetInt("highscore6",0).ToString();
        highscoreText7.text = "7.	" +  PlayerPrefs.GetString("Name7") + "  " + PlayerPrefs.GetInt("highscore7",0).ToString();
        highscoreText8.text = "8.	" +  PlayerPrefs.GetString("Name8") + "  " +  PlayerPrefs.GetInt("highscore8",0).ToString();
        highscoreText9.text = "9.	" +  PlayerPrefs.GetString("Name9") + "  " +  PlayerPrefs.GetInt("highscore9",0).ToString();
        highscoreText10.text = "10. " +  PlayerPrefs.GetString("Name10") + "  " + PlayerPrefs.GetInt("highscore10",0).ToString();
    }
    public void BacktoGameOver(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
   

    
    
}
