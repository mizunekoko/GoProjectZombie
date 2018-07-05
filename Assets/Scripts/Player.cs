using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody _m_rigidbody;

	// Use this for initialization
	void Start () {
		_m_rigidbody =	this.GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		float x = 0;
		float z = 0;
		Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

		if(touchPadPt.x > 0.5f && -0.5f < touchPadPt.y && touchPadPt.y < 0.5f){
			x += 1f;
		}else if(touchPadPt.x < -0.5f && -0.5f < touchPadPt.y && touchPadPt.y < 0.5f){
			x -= 1f;
		}else if(touchPadPt.y > 0.5f && -0.5f < touchPadPt.x && touchPadPt.x < 0.5){
			z += 1f;
		}else if(touchPadPt.y < -0.5f && -0.5f < touchPadPt.x && touchPadPt.x < 0.5f){
			z -= 1f;
		}else{

		}

		_m_rigidbody.velocity = z * transform.forward + x * transform.right;

	}

}
