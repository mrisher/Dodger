using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private int score;
	public GUIText scoreText;


	//Speed of the Player
	public float speed = 10.0F;

	//bounds of player
	public float leftBound = -5F;
	public float rightBound = 5F;
	public float upBound = 3.5F;
	public float downBound = -3.5F;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	}

	// Update is called once per frame
	void Update () {
		//Horizontal Speed
		float movementSpeedX = Time.deltaTime * Input.GetAxis("Horizontal") * speed;        
		//Vertical Speed
		float movementSpeedY = Time.deltaTime * Input.GetAxis("Vertical") * speed;          
		//Player Movement
		transform.Translate(movementSpeedX, movementSpeedY, 0);                         

		//creates bounds around player
		if(transform.position.x > rightBound){
			transform.position = new Vector3(rightBound,transform.position.y,0);
		} else if(transform.position.x < leftBound){
			transform.position = new Vector3(leftBound,transform.position.y,0);
		}

		if(transform.position.y > upBound){
			transform.position = new Vector3(transform.position.x,upBound,0);
		} else if(transform.position.y < downBound){
			transform.position = new Vector3(transform.position.x,downBound,0);
		}
	}

	public void IncrementScore() {
		score += 1;
		UpdateScore ();
	}

	public void UpdateScore() {
		scoreText.text = "Score: " + score;
	}
}

