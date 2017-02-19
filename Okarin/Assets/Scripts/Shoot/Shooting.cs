using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting : MonoBehaviour {

	public float m_speed = 1f;

	private Vector3 direction;

	private Transform tr;

	void OnEnable(){
		tr = this.GetComponent<Transform> ();
		direction = new Vector3 (CrossPlatformInputManager.GetAxis ("Horizontal") > 0 ? 1 :0,
			CrossPlatformInputManager.GetAxis ("Vertical") > 0 ? 1 : 0, 0);
//		Debug.Log (direction);
		StartCoroutine (Wait());
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (3f);
		this.gameObject.SetActive (false);


	}

	// Update is called once per frame
	void FixedUpdate () {
		tr.position = tr.position + direction * m_speed * Time.fixedDeltaTime ;
	}
}
