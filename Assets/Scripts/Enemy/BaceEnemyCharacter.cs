using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaceEnemyCharacter : MonoBehaviour {

	public int _max_life;
	public int _life_count;
	public Collision _col;
	public string _name;
	private GameObject _head_name;
	public List<string> _hit_position = new List<string>();

	//初期化
	public virtual void Inisialize(){
		_life_count = 0;
		_head_name = GameObject.Find("OVRCameraRig");
	}

	//相手を見る
	public virtual void LookCamera(){
		Vector3 c = _head_name.transform.position;
		c.y = this.transform.position.y;
		this.transform.LookAt(c);
	}

	//死んだら
	public void ThisDestroy(){
		if(_life_count >= _max_life){
			Destroy(this.gameObject);
		}
	}

	public void HitPosition(Collision col, string name, List<string> pos){
		if(pos[_life_count] == name){
			_life_count++;
		}
		Destroy(col.gameObject);
		this.ThisDestroy();
	}

}
