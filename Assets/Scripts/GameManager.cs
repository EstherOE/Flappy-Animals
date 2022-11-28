using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
	[Header ("GUI Section ")]
	[SerializeField] TextMeshProUGUI ScoreText;
	public GameObject gameover;
	[SerializeField] TextMeshProUGUI CountDownText;
	
	[SerializeField] GameObject countObj;
	bool CountDown;
	public bool hasStarted;
	[HideInInspector] public bool isGameOver;
	public float counter;
	
	public static GameManager instance;
	private int scoreInt;
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
        
		isGameOver= false;
	}
	void Start()
	{
		scoreInt =0;
		ScoreText.text = "Score : "+ scoreInt;
	
		CountDown= true;
		
		//Count();
		if (CountDown)
		{
			if (CountDownText != null)
			{
				StartCoroutine(StartCountDown());
			}
			else
			{
				Debug.LogError("Timer is not setup");
			}
		}
		else
		{
			hasStarted = true;
		}
	}
	
	IEnumerator StartCountDown()
	{
		CountDownText.gameObject.SetActive(true);
		
		CountDownText.text = "3";
		yield return new WaitForSecondsRealtime(1f);
		CountDownText.text = "2";
		yield return new WaitForSecondsRealtime(1f);
		CountDownText.text = "1";
		yield return new WaitForSecondsRealtime(1f);
		hasStarted = true;
		CountDownText.text = "GO!";
		yield return new WaitForSecondsRealtime(1f);
		countObj.SetActive(false);
	}
	


	public void GameOver()
	{
		gameover.SetActive(true);
	}
	
	
	public void AdditionalScore(int score)
	{
		
		scoreInt  += score;
		ScoreText.text = "Score: "+ scoreInt;
	}
}
