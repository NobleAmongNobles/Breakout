using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	public void Backtomenu()
	{
		SceneManager.LoadScene(0);
	}
}