using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private Transform tr;

	public float enemy_speed = 2f;

	[Header("Time in which change direction")]
	public float change_direction_time = 5f;

	private Vector3 movement;

	bool is_time_to_change_direction = true;
	// Use this for initialization
	void Start () {
		tr = this.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate() {
		if(is_time_to_change_direction){
			movement = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),0);
			is_time_to_change_direction = false;
			StartCoroutine (WaitToChangeDirection());
		}
		tr.position = tr.position + movement * Time.fixedDeltaTime;
	}

	IEnumerator WaitToChangeDirection(){
		yield return new WaitForSeconds (change_direction_time);
		is_time_to_change_direction = true;


	}







}
