using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
   
	[SerializeField] Button [] disableButton;
	
	public void Disable()
	{
		
		for(int i =0; i<disableButton.Length; i++)
		{
			disableButton[i].interactable= false;
		}
	}
}
