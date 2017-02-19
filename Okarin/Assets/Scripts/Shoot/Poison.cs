using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour {


	[Header("Speed")]
	public float m_speed= 4f;

	private Transform tr;

	Vector3 direction;

	// Use this for initialization
	void OnEnable() {
		tr = this.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void FixedUpdate() {
		
		direction = (GameObject.FindWithTag("Player").transform.position - tr.position).normalized;

		Debug.DrawRay (Vector3.zero, tr.position, Color.red, 100f, false);
		//tr.position = tr.position + Time.fixedTime * m_speed * direction;
	}
}
