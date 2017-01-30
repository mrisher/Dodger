using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	//speed of Enemy
	public float speed = 8F;

	private PlayerController playerController;

	//Camera camera;

	void Start() {
		//camera = GetComponent<Camera>();
		GameObject playerControllerObject = GameObject.FindWithTag ("Player");
		if (playerControllerObject != null)
		{
			playerController = playerControllerObject.GetComponent <PlayerController>();
		}
		if (playerController == null)
		{
			Debug.Log ("Cannot find 'PlayerController' script");
		}	
	}

	// Update is called once per frame
	void Update () {
		//Movement of Enemy
		transform.Translate(0, -speed * Time.deltaTime, 0);
	}

	void OnTriggerEnter2D(Collider2D other){

		//Checks if other gameobject has a Tag of Player
		if(other.gameObject.tag == "Player"){
			//Pauses gameplay
			Time.timeScale = 0;         
		}
	}

	void OnBecameInvisible() {
		playerController.IncrementScore();
	}


}