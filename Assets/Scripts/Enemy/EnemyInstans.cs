using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstans : MonoBehaviour {

	public GameObject _enemy_object;
	public GameObject _enemy_object2;
	private float _time;

	// Use this for initialization
	void Start () {
		_time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		_time += Time.deltaTime*1;
		if(_time >= 5){
			Instantiate(_enemy_object, this.transform.position, Quaternion.identity);
			_time = 0;
		}

	}
}
