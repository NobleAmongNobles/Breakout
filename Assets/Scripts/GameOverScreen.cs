using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameOverScreen : MonoBehaviour
{	
	public Text finalScorePlayer1;
	public Text finalScorePlayer2;
	public Text newHighscore;
	public Text highScoreName1;
	public Text highScoreName2;

	void Awake(){
		if(ScoreManager.instance.score1 > ScoreManager.instance.highscores.ElementAt(9).point || ScoreManager.instance.score2 > ScoreManager.instance.highscores.ElementAt(9).point ){
			newHighscore.enabled = true;
		}else{
			newHighscore.enabled = false;
		}
		finalScorePlayer2.text = "Final Score Player 2: " + ScoreManager.instance.score2.ToString();
		finalScorePlayer1.text = "Final Score Player 1: " + ScoreManager.instance.score1.ToString();
	}
	public void NewHighscoreName1(){
		ScoreManager.instance.NewHighscore(new HighscoreElement(highScoreName1.text, ScoreManager.instance.score1));	
	}
	public void NewHighscoreName2(){
		ScoreManager.instance.NewHighscore(new HighscoreElement(highScoreName2.text, ScoreManager.instance.score2));
	}
	public void HighscoreListe(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void BackToMenu()
	{
		SceneManager.LoadScene(0);
	}


}
