using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType2 : BaceEnemyCharacter {

	// Use this for initialization
	void Start () {
		base.Inisialize();
		base._max_life = 2;
		base._hit_position = new List<string>();
		base._hit_position.Add("2");
		base._hit_position.Add("2");
	}
	
	// Update is called once per frame
	void Update () {
		base.LookCamera();
	}

	public void Hit(Collider col, string name){
		base._col = col;
		base._name = name;
		base.HitPosition(base._col ,base._name, base._hit_position);
	}

}
