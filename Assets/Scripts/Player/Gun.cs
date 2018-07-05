using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public GameObject _bullet;
	public GameObject _muzzle;
	private AudioSource _shotSound;

	// Use this for initialization
	void Start () {
		_shotSound = this.transform.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)){
			GameObject bullet =  Instantiate(_bullet, _muzzle.transform.position, _muzzle.transform.rotation) as GameObject;
			_shotSound.PlayOneShot(_shotSound.clip);
		}

	}
}
