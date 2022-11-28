using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOvermanager : MonoBehaviour
{
	public static GameOvermanager instance;
	[HideInInspector]public bool isGameOver;
	public  GameObject gameOver;
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	
	// Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.
	protected void Start()
	{
		isGameOver= false;
	}
	public GameObject overManger;
	public void GameOver()
	{
		
	
		gameOver.SetActive(true);
		overManger.SetActive(true);
		
	}
}
