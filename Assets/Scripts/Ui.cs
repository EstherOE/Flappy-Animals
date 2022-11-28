using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ui : MonoBehaviour
{
	[SerializeField] string gamePlayWord, homePlayWord;
	public void Pause()
	{
		Time.timeScale=0;
		
	}
	
	public void Resume()
	{
		
		Time.timeScale=1;
	}
	
	
	public void Restart()
	{
		Time.timeScale=1;
		SceneManager.LoadScene(gamePlayWord);
		
		
	}
	
	public void Exit()
	{
		Debug.Log("exit");
		Application.Quit();
	}
	
	public void Home()
	{
		Time.timeScale=1;
		SceneManager.LoadScene(homePlayWord);
	}
	
	
}
