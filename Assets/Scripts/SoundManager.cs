using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
	
	[SerializeField] Button []soundButton;
	[SerializeField] AudioClip[] audioClip;
	[SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
	    for(int i =0; i<soundButton.Length; i++)
	    {
	    	int index =i;
	    	soundButton[index].onClick.AddListener(()=> this.TaskOnClick(index));
	    	
	    }
    }

    // Update is called once per frame
	void TaskOnClick(int dindex)
    {
	    source.clip= audioClip[dindex];
	    source.Play();
    }
}
