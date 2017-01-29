using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}

	//Reloads the Level
	public void Reload(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}