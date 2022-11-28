using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Player : MonoBehaviour
{



	[SerializeField] float tapForce = 10f;
	private Vector3 direction;
	[SerializeField] float strength;
	
  
	//Tag Section
    private string ENEMY_TAG = "Enemy";
	private string GROUND_TAG="Ground";
	private string UP_TAG="Sky";
	private string SCORE_TAG="Score";
	
	private Animator anim;
    private void Awake()
    {

	    anim= GetComponent<Animator>();
	    
  }

	
    // Update is called once per frame
    void Update()
	{
		
		if(GameManager.instance.hasStarted==true){
        PlayerMoveKeyboard();
		
		}
    }

    

    void PlayerMoveKeyboard() {
	    //KeyBoard movement
     if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
     {
     	direction= Vector3.up*strength;
     	anim.SetBool("Walk", true);
     }
     
     //control for andoroid
     if(Input.touchCount>0)
     {
     	Touch ouch= Input.GetTouch(0);
     	
     	if(ouch.phase==TouchPhase.Began)
     	{
     		
     		direction= Vector3.up*strength;
     		anim.SetBool("Walk", true);
     	}
     	
     }
     
     
     direction.y +=tapForce* Time.deltaTime;
     transform.position +=direction* Time.deltaTime;
    }

   
    

   

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag(GROUND_TAG)) { 
			Time.timeScale= 0;
			
			Destroy(gameObject);   
			GameManager.instance.GameOver();
			
		}
	
		if (collision.CompareTag(UP_TAG)) { 
			Time.timeScale= 0;
			
			Destroy(gameObject);   
			GameManager.instance.GameOver();
			
		}
	   
	   
		if(collision.CompareTag(ENEMY_TAG))
		{
			Time.timeScale= 0;
			
			Destroy(gameObject);   
			GameManager.instance.GameOver();
		}
	
		if(collision.CompareTag(SCORE_TAG))
		{
			
			GameManager.instance.AdditionalScore(1);
		}
	}

} // class






























