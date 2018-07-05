using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private int _life;
	public GameObject _target;
	private float _distance;
	private float _speed;
	private float _start_time;

	// Use this for initialization
	void Start () {
		_life = 1;
		_speed = 0.1f;
		_start_time = Time.time;
		_distance = (_target.transform.position - this.transform.position).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - _start_time) * _speed;
		float fracJourney = distCovered / _distance;
		this.transform.position  = Vector3.Lerp(_target.transform.position, this.transform.position, fracJourney);
		if( Mathf.Abs((_target.transform.position - this.transform.position).magnitude) <= 0 ){
			Destroy(this.transform.gameObject);
		}

	}
}
