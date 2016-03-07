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

	private float speed;

	private Vector2 dir;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.O)) {
			matNum = matNum + 1;
			if (matNum == 4) {
				matNum = 0;
			}
		}


		GetComponent<TrailRenderer> ().material = materials [matNum];

		moveHoriz = Input.GetAxis("Horizontal");
		moveVert = Input.GetAxis("Vertical");
		moveHorizR = Input.GetAxis("HorizontalRIGHT");
		moveVertR = Input.GetAxis("VerticalRIGHT");

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


}
