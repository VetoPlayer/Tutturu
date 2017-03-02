using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour {


	[Header("Speed")]
	public float m_speed= 1f;

	private Transform tr;

	Vector3 direction;

	// Use this for initialization
	void OnEnable() {
		tr = this.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void FixedUpdate() {
		
		direction = (GameObject.FindWithTag("Player").transform.position - tr.position).normalized;
		tr.position = tr.position + Time.fixedDeltaTime * m_speed * direction;
	}
}
