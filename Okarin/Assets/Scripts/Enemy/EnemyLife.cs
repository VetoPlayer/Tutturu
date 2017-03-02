using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {


	[Header("Enemy Life")]

	public int life = 100;


	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Shoot") {
			Debug.Log ("Enemy Hit!!!");
			other.gameObject.SetActive (false);
			life = life--;
		}

	}
}
