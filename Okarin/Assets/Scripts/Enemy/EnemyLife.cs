using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {


	[Header("Enemy Life")]

	public int life = 100;

	[Header("Damage per shoot received")]

	public int damage = 1;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		life = life - damage;
	}
}
