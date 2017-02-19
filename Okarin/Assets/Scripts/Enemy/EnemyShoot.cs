using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

	public GameObject enemy_shoot;

	public Transform shoot_position;

	private float time_passed;
	[Header("Shooting Time")]
	public float shooting_time = 3f;


	// Use this for initialization
	void Start () {
		ObjectPoolingManager.Instance.CreatePool (enemy_shoot,20,20);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time_passed = time_passed + Time.fixedDeltaTime;
		if(time_passed >= shooting_time){
			Debug.Log ("Shooted!");
			time_passed = 0f;
			GameObject shoot = ObjectPoolingManager.Instance.GetObject (enemy_shoot.name);
			shoot.transform.position = shoot_position.position;
			shoot.transform.rotation = Quaternion.identity;

		}
	}
}
