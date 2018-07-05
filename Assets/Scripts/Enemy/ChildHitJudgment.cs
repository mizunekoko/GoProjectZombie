using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildHitJudgment : MonoBehaviour {

	private GameObject _parent;

	public enum EnemyType{
		EnemyType1,
		EnemyType2
	};

	//private string EnemyType1 = "EnemyType1";
	//private string EnemyType2 = "EnemyType2";

	public EnemyType _enemyTypeScript;


	void Start(){
		_parent = this.gameObject.transform.root.gameObject;
	}

	public void OnCollisionEnter(Collision collision){
		Debug.Log("wwerty");
		switch (_enemyTypeScript){
			case EnemyType.EnemyType1:
				EnemyType1 type;
				type = gameObject.transform.root.gameObject.transform.GetComponent<EnemyType1>();
				Debug.Log(collision.gameObject.tag);
				if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Player") {
					Debug.Log("sssssssss");
					type.Hit(collision, this.gameObject.name);
				};
			break;

			case EnemyType.EnemyType2:
				EnemyType2 type2;
				type2 = gameObject.transform.root.gameObject.transform.GetComponent<EnemyType2>();
				if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Player") {
					type2.Hit(collision, this.gameObject.name);
				};
			break;

			default:
			break;

		}

	}

}
