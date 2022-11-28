using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBG : MonoBehaviour
{
	Material mat;
	float distance;
	
	[Range(0,0.5f)]public float speeed =.02f;
	
	
	// Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.
	protected void Start()
	{
		mat = GetComponent<Renderer>().material;
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		distance += Time.deltaTime*speeed;
		
		mat.SetTextureOffset("_MainTex", Vector2.right* distance);
	}
	
}
