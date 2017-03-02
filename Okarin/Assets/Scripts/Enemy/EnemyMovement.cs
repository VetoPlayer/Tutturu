using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private Transform tr;

	private bool is_going_right= true;

	public float enemy_speed = 2f;

	[Header("Time in which the enemy changes direction")]
	[Range(0,10)]
	public float change_direction_time = 5f;

	public float time_passed;

	private Vector3 movement = Vector3.right;

	// Use this for initialization
	void Start () {
		tr = this.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate() {
		tr.position = tr.position + movement * Time.fixedDeltaTime * enemy_speed;
		if(time_passed >= change_direction_time){
			if (is_going_right) {
				movement = Vector3.left;
				is_going_right = false;
				time_passed = 0;
			} else {
				movement = Vector3.right;
				is_going_right = true;
				time_passed = 0;
			}
		}
		time_passed = time_passed + Time.fixedDeltaTime;
	}

	IEnumerator WaitToChangeDirection(){
		yield return new WaitForSeconds (change_direction_time);


	}







}
