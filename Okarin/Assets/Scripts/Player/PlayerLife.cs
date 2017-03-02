using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {

	[Header("Player Life")]
	[Range(0,400)]
	public int m_player_life = 100;
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Poison") {
			Debug.Log ("Poison collided");
			other.gameObject.SetActive (false);
			m_player_life--;
		}
	}
}
