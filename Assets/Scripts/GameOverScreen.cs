using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameOverScreen : MonoBehaviour
{	
	public Text finalscorePlayer1;
	public Text finalScorePlayer2;
	public Text newHighscore;
	public Button speichern;
	public InputField spieler;
	public Text highScoreName;
	public Text highscoreText1;
	public Text highscoreText2;
	public Text highscoreText3;

	void Awake(){
		if(ScoreManager.instance.score1 > ScoreManager.instance.highscores.ElementAt(9).point || ScoreManager.instance.score2 > ScoreManager.instance.highscores.ElementAt(9).point ){
			newHighscore.enabled = true;
		}else{
			newHighscore.enabled = false;
		}
		finalscorePlayer1.text = "Final Score Player 1: " + ScoreManager.instance.score1.ToString();
		finalScorePlayer2.text = "Final Score Player 2: " + ScoreManager.instance.score2.ToString();
	}
	public void NewHighscoreName1(){
		Debug.Log(highScoreName.text);
		ScoreManager.instance.NewHighscore(new HighscoreElement(highScoreName.text, ScoreManager.instance.score1));	
	}
	public void NewHighscoreName2(){
		ScoreManager.instance.NewHighscore(new HighscoreElement(highScoreName.text, ScoreManager.instance.score2));
	}
	public void HighscoreListe(){
		SceneManager.LoadScene(4);
	}
	public void Backtomenu()
	{
		SceneManager.LoadScene(0);
	}


}
