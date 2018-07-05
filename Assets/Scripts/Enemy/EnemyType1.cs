using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : BaceEnemyCharacter {

	Animator _animator;
	// Use this for initialization
	void Start () {
		base.Inisialize();
		base._max_life = 2;
		base._hit_position = new List<string>();
		base._hit_position.Add("1");
		base._hit_position.Add("1");
		_animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		base.LookCamera();
	}

	public void Hit(Collider col, string name){
		base._col = col;
		base._name = name;
		base.HitPosition(base._col ,base._name, base._hit_position);

		if(col.gameObject.tag == "Player"){
			_animator.SetInteger("State", 1);
		}

	}
}
