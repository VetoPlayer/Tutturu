using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : Singleton<MenuManager> {

	public GameObject credits_panel;

    protected MenuManager() { }

	public void StartGame(){
		SceneManager.LoadScene ("Main");
	}

	public void ShowCredits(){
		credits_panel.SetActive (true);
	}
}
