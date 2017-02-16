using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting : MonoBehaviour {

	public float m_speed = 0.1f;

	private Transform tr;

	void OnEnable(){
		tr = this.GetComponent<Transform> ();
		StartCoroutine (Wait());
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (3f);
		this.gameObject.SetActive (false);


	}

	// Update is called once per frame
	void FixedUpdate () {
		tr.position = tr.position + new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"),
			CrossPlatformInputManager.GetAxis("Vertical"),0) * m_speed * Time.fixedDeltaTime ;
	}
}
