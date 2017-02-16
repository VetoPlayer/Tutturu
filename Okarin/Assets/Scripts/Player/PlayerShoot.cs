using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerShoot : MonoBehaviour {

	public GameObject m_shoot_prefab;

	[Header("Shoot Position")]
	public Transform shoot_position;
	// Use this for initialization
	void Start () {
		ObjectPoolingManager.Instance.CreatePool (m_shoot_prefab, 20, 20);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (CrossPlatformInputManager.GetButtonDown ("Shoot")) {
			GameObject shoot = ObjectPoolingManager.Instance.GetObject (m_shoot_prefab.name);
			shoot.transform.position = shoot_position.position;
			shoot.transform.rotation = Quaternion.identity;
		}
		
	}
}
