using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private int _speed;
	private float _time;

	private const int DESTROY_TIME = 3; //Ballet destroy
	// Use this for initialization
	void Start () {
		_speed = 900;
		_time = 0;
		this.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

	}
	
	// Update is called once per frame
	void Update () {
		_time += Time.deltaTime;

		Vector3 force;
		force = this.gameObject.transform.forward * _speed;
		this.GetComponent<Rigidbody>().AddForce(force);
		if(_time >= DESTROY_TIME){
			Destroy(this.gameObject);
		}

	}
}
