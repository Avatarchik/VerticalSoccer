using UnityEngine;
using System.Collections;

public class testJoystick : MonoBehaviour {


	public Material[] materials;
	public int matNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		GetComponent<TrailRenderer> ().material = materials [matNum];

		float moveHoriz = Input.GetAxis("Horizontal");
		float moveVert = Input.GetAxis("Vertical");

		Vector2 dir = new Vector2 (moveHoriz, moveVert);

		if (moveHoriz > 0) {
			print ("working");
		} 

		if (Input.GetButtonDown("Jump")) {
			GetComponent<Rigidbody2D> ().AddForce (dir * 900);
		}



		//Vector2 targetDirection = new Vector3( touchPosition.x, 0f touchPosition.y );
	}
}
