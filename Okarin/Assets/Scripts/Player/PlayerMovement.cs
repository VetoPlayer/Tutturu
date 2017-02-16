using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : Singleton<PlayerMovement> {

	private PlayerMovement(){ }

	[Header("Player Speed")]
	public float m_speed=1f;


	Rigidbody2D body;
	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate(){

		Vector2 movevec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"));
		Debug.Log (movevec);
		body.AddForce (movevec);
	}
		


}
