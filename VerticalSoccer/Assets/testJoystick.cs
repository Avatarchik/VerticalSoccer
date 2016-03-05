using UnityEngine;
using System.Collections;

public class testJoystick : MonoBehaviour {


	public GameObject ball;

	public Material[] materials;
	public int matNum;

	private float moveHoriz;
	private float moveVert;
	private float moveHorizR;
	private float moveVertR;

	private Vector2 dir;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		GetComponent<TrailRenderer> ().material = materials [matNum];

		moveHoriz = Input.GetAxis("Horizontal");
		moveVert = Input.GetAxis("Vertical");
		moveHorizR = Input.GetAxis("HorizontalRIGHT");
		moveVertR = Input.GetAxis("VerticalRIGHT");

		dir = new Vector2 (moveHorizR, moveVertR);

		//Vector2 targetDirection = new Vector3( touchPosition.x, 0f touchPosition.y );
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.CompareTag ("Player")) {
			ball.GetComponent<Rigidbody2D> ().AddForce (dir * 500);
		}
	}
}
