using UnityEngine;
using System.Collections;
using Rewired; // REWIRED STUF ~~~~~~~~~~

[RequireComponent(typeof(CharacterController))] // REWIRED STUF ~~~~~~~~~~

public class testJoystick : MonoBehaviour {

	public int playerId = 0; // The Rewired player id of this character // REWIRED STUF ~~~~~~~~~~
	private Player player; // The Rewired Player  // REWIRED STUF ~~~~~~~~~~
	private CharacterController cc; // REWIRED STUF ~~~~~~~~~~

	public GameObject ball;

	public Material[] materials;
	public int matNum;

	private float moveHoriz;
	private float moveVert;
	private float moveHorizR;
	private float moveVertR;

	private float speed;

	private Vector2 dir;



	// Use this for initialization
	void Start () {

		// Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
		player = ReInput.players.GetPlayer(playerId); // REWIRED STUF ~~~~~~~~~~

		// Get the character controller
		cc = GetComponent<CharacterController>(); // REWIRED STUF ~~~~~~~~~~
	
	}
	
	// Update is called once per frame
	void Update () {

	
		// BALL FORCE TEST ====================

		if (Input.GetKeyDown (KeyCode.P)) {
			ball.GetComponent<Rigidbody2D> ().AddForce (transform.up * 1000);
		}

		//COLOR CHANGE TEST ====================

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			matNum = 0;
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			matNum = 1;
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			matNum = 2;
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			matNum = 3;
		}

		// ======================================


		GetComponent<TrailRenderer> ().material = materials [matNum];


		/*
		moveHoriz = Input.GetAxis("Horizontal");
		moveVert = Input.GetAxis("Vertical");
		moveHorizR = Input.GetAxis("HorizontalRIGHT");
		moveVertR = Input.GetAxis("VerticalRIGHT");
		*/

		moveHoriz = player.GetAxis("MoveHorizontal");
		moveVert = player.GetAxis("MoveVertical");
		moveHorizR = player.GetAxis("MoveHorizontalR");
		moveVertR = player.GetAxis("MoveVerticalR");


		dir = new Vector2 (moveHorizR, moveVertR);


	}

	void OnTriggerStay2D(Collider2D other){
		if (other.CompareTag ("Player") && other.GetComponent<playerKick>().kicked == false) {
			ball.GetComponent<Rigidbody2D> ().AddForce (dir * 500);
		}
	}

	void OnDestroy (){
		Destroy (ball);
	}
	/*

	private void ProcessInput() {
		// Process movement
		if(moveVector.x != 0.0f || moveVector.y != 0.0f) {
			cc.Move(moveVector * moveSpeed * Time.deltaTime);
		}

		// Process fire
		if(fire) {
			GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position + transform.right, transform.rotation);
			bullet.rigidbody.AddForce(transform.right * bulletSpeed, ForceMode.VelocityChange);
		}
	}
	*/



}
