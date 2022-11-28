using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class CharacterManager : MonoBehaviour
{   
	// UI Section
	
	int  scoreInt;
	//character section
	[Header ("Character List ")]
    [SerializeField]
    private GameObject[] characters;
	private int _charIndex;
	public int CharIndex
	{
		get { return _charIndex; }
		set { _charIndex = value; }
	}
	
	
	public static CharacterManager instance;
	
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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode) {

	    if (scene.name == "Gameplay") {
		    
		    Instantiate(characters[CharIndex]);
	    }
        
	    if (scene.name == "Gameplay 1") {
		    
		    Instantiate(characters[CharIndex]);
	    }
	    
	    if (scene.name == "Gameplay 2") {
		    
		    Instantiate(characters[CharIndex]);
	    }
	    
	    
	    if (scene.name == "Gameplay 3") {
		    
		    Instantiate(characters[CharIndex]);
	    }
        
	    if (scene.name == "Gameplay 4") {
		    
		    Instantiate(characters[CharIndex]);
	    }
	    
	    if (scene.name == "Gameplay 5") {
		    
		    Instantiate(characters[CharIndex]);
	    }
	    
	    
	    if (scene.name == "Gameplay 6") {
		    
		    Instantiate(characters[CharIndex]);
	    }
	    
	    if (scene.name == "Gameplay 7") {
		    
		    Instantiate(characters[CharIndex]);
	    }

    }
	


} /// class


























