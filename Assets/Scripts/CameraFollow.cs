using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;

    private Vector3 tempPos;
	public float speed;
	[SerializeField]public float posx,posy,posz;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {

	    Vector3 newpos= new Vector3(player.position.x +posx,posy,posz);
	    
	    transform.position= Vector3.Slerp(transform.position,newpos,speed* Time.deltaTime);

    }



} // class






















