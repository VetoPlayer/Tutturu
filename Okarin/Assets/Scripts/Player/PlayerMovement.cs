using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : Singleton<PlayerMovement> {

	private PlayerMovement(){ }

	private Transform tr; 
	[Header("Player Speed")]
	public float m_speed=1f;

	// Use this for initialization
	void Start () {
		tr = this.GetComponent<Transform> ();
	}
	
	void FixedUpdate(){

		Vector3 movement = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"),
				CrossPlatformInputManager.GetAxis("Vertical"),0);
		tr.position = tr.position + movement * m_speed * Time.fixedDeltaTime;
	}
		


}
