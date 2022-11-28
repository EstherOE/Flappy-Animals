using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	
	[SerializeField] private GameObject _prefab;
	[SerializeField] private float _time;
	[SerializeField] private float yClamp;
	[SerializeField] private float _yClamp;
	private float _elapsedTime;

	private void Update()
	{
		if(GameManager.instance.hasStarted==true){
		_elapsedTime += Time.deltaTime;

		if (_elapsedTime > _time)
		{
			SpawnObject();

			_elapsedTime = 0f;
		}
		}
	}
	
	private void SpawnObject()
	{
		float offsetY = UnityEngine.Random.Range(_yClamp, yClamp);

		Vector2 pos = new Vector2(this.transform.position.x+22, this.transform.position.y + offsetY);

		Instantiate(_prefab, pos, Quaternion.identity);
	}
    
}
